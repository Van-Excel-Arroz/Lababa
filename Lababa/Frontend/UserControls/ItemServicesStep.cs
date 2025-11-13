using Lababa.Backend.Models;
using Lababa.Backend.Services;
using Lababa.Frontend.UserControls.Interfaces;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Lababa.Frontend.UserControls
{
    public partial class ItemServicesStep : UserControl, IWizardStep
    {
        private readonly ItemServiceCatalogService _service;
        private BindingList<ItemService> _itemServiceCatalog;

        public ItemServicesStep()
        {
            InitializeComponent();
            _service = new ItemServiceCatalogService();
            _itemServiceCatalog = new BindingList<ItemService>();
        }

        private void WeightServicesStep_Load(object sender, System.EventArgs e)
        {
            dgvItemServiceCatalog.AutoGenerateColumns = false;

            var initialServices = _service.GetItemServiceCatalog();
            _itemServiceCatalog = new BindingList<ItemService>(initialServices);
            dgvItemServiceCatalog.DataSource = _itemServiceCatalog;
        }

        private void dgvWeightServices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvItemServiceCatalog.Columns["colRemoveImage"].Index && e.RowIndex >= 0)
            {
                e.Value = Properties.Resources.trash_2;
            }
        }

        private void dgvWeightServices_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvItemServiceCatalog.Columns["colRemoveImage"].Index)
            {
                dgvItemServiceCatalog.Cursor = Cursors.Hand;
            }
        }

        private void dgvWeightServices_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvItemServiceCatalog.Cursor = Cursors.Default;
        }

        private void dgvWeightServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvItemServiceCatalog.Columns["colRemoveImage"].Index)
            {
                ItemService serviceToRemove = _itemServiceCatalog[e.RowIndex];
                _itemServiceCatalog.Remove(serviceToRemove);
            }
        }

        public bool ValidateStep()
        {
            if (_itemServiceCatalog.LastOrDefault() is ItemService last && string.IsNullOrWhiteSpace(last.ItemName))
            {
                _itemServiceCatalog.Remove(last);
            }

            if (_itemServiceCatalog.Count == 0)
            {
                MessageBox.Show("Please add at least one item service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (var service in _itemServiceCatalog)
            {
                if (string.IsNullOrWhiteSpace(service.ItemName))
                {
                    MessageBox.Show("Item Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (service.PricePerPiece < 0)
                {
                    MessageBox.Show($"The price for '{service.ItemName}' cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }

            return true;
        }

        public void SaveStepData()
        {
            _service.SaveCatalog(_itemServiceCatalog.ToList());
        }
    }
}
