using Lababa.Backend.Models;
using Lababa.Backend.Services;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

namespace Lababa.Frontend.UserControls
{
    public partial class ItemServiceControl : UserControl
    {
        private ApplicationSettings _appSettings;
        public event EventHandler RemoveClicked;
        public event EventHandler DropDownValueChanged;
        public event EventHandler WeightChanged;

        public ItemService GetItemService
        {
            get { return cmbItemServiceCatalog.SelectedItem as ItemService; }
        }

        public int GetQuantity
        {
            get { return Convert.ToInt16(nudQuantity.Value); }
        }

        public ItemServiceControl()
        {
            InitializeComponent();
            InitializeCommon();
            cmbItemServiceCatalog.SelectedIndex = 0;
        }

        public ItemServiceControl(OrderItemItem orderItemItem)
        {
            InitializeComponent();
            InitializeCommon();

            cmbItemServiceCatalog.SelectedValue = orderItemItem.ServiceId;
            nudQuantity.Value = orderItemItem.Quantity;
        }

        private void InitializeCommon()
        {
            _appSettings = Program.ServiceProvider.GetRequiredService<ApplicationSettingsService>().LoadSettings();
            var catalogService = Program.ServiceProvider.GetRequiredService<ItemServiceCatalogService>();
            var itemServiceCatalog = new BindingList<ItemService>(catalogService.GetAll());

            cmbItemServiceCatalog.DataSource = itemServiceCatalog;
            cmbItemServiceCatalog.DisplayMember = "ItemName";
            cmbItemServiceCatalog.ValueMember = "Id";

            AddInteractiveEffectsRecursively(this);
        }

        public decimal GetTotalPrice()
        {
            if (cmbItemServiceCatalog.SelectedItem is ItemService itemService)
            {
                return itemService.PricePerPiece * nudQuantity.Value;
            }
            return 0;
        }

        private void AddInteractiveEffectsRecursively(Control control)
        {
            control.MouseEnter += (s, e) =>
            {
                this.BackColor = Color.FromArgb(250, 250, 250);
            };

            control.MouseLeave += (s, e) =>
            {

                Point mousePos = this.PointToClient(Cursor.Position);

                if (!this.ClientRectangle.Contains(mousePos))
                {
                    this.BackColor = Color.White;
                }
            };


            foreach (Control child in control.Controls)
            {
                AddInteractiveEffectsRecursively(child);
            }
        }
        private void cmbWeightServiceCatalog_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (cmbItemServiceCatalog.SelectedItem is ItemService selectedService)
            {
                txtPricePerPiece.Text = $"{_appSettings.CurrencySymbol}{selectedService.PricePerPiece:F2}";
                DropDownValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void pbxRemove_Click(object sender, System.EventArgs e)
        {
            RemoveClicked?.Invoke(this, EventArgs.Empty);
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            WeightChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
