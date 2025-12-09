using Lababa.Backend.Models;
using Lababa.Backend.Services;
using Lababa.Frontend.UserControls.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

namespace Lababa.Frontend.UserControls
{
    public partial class WeightServicesStep : UserControl, IWizardStep
    {
        private WeightServiceCatalogService _service;
        private BindingList<WeightService> _weightServiceCatalog;

        public WeightServicesStep()
        {
            InitializeComponent();
        }

        public WeightServicesStep(WeightServiceCatalogService weightServiceCatalogService)
        {
            InitializeComponent();
            _service = weightServiceCatalogService;
            _weightServiceCatalog = new BindingList<WeightService>();
        }

        private void WeightServicesStep_Load(object sender, System.EventArgs e)
        {
            if (!DesignMode && _service == null)
            {
                _service = Program.ServiceProvider.GetRequiredService<WeightServiceCatalogService>();
            }

            if (DesignMode || _service == null) return;

            dgvWeightServiceCatalog.AutoGenerateColumns = false;

            var initialServices = _service.GetAll();
            _weightServiceCatalog = new BindingList<WeightService>(initialServices);
            dgvWeightServiceCatalog.DataSource = _weightServiceCatalog;
        }

        private void dgvWeightServices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvWeightServiceCatalog.Columns["colRemoveImage"].Index && e.RowIndex >= 0)
            {
                e.Value = Properties.Resources.trash_2;
            }
        }

        private void dgvWeightServices_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvWeightServiceCatalog.Columns["colRemoveImage"].Index)
            {
                dgvWeightServiceCatalog.Cursor = Cursors.Hand;
            }
        }

        private void dgvWeightServices_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvWeightServiceCatalog.Cursor = Cursors.Default;
        }

        private void dgvWeightServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvWeightServiceCatalog.Columns["colRemoveImage"].Index)
            {
                WeightService serviceToRemove = _weightServiceCatalog[e.RowIndex];
                _weightServiceCatalog.Remove(serviceToRemove);
            }
        }

        public bool ValidateStep()
        {
            if (_weightServiceCatalog.LastOrDefault() is WeightService last && string.IsNullOrWhiteSpace(last.ServiceName))
            {
                _weightServiceCatalog.Remove(last);
            }

            if (_weightServiceCatalog.Count == 0)
            {
                MessageBox.Show("Please add at least one weight service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (var service in _weightServiceCatalog)
            {
                if (string.IsNullOrWhiteSpace(service.ServiceName))
                {
                    MessageBox.Show("Service Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (service.PricePerUnit < 0)
                {
                    MessageBox.Show($"The price for '{service.ServiceName}' cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (service.MinWeightPerLoad < 0)
                {
                    MessageBox.Show($"The minimum weight for '{service.ServiceName}' cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        public void SaveStepData()
        {
            _service.UpdateCatalog(_weightServiceCatalog.ToList());
        }
    }
}
