using Lababa.Backend.Models;
using Lababa.Backend.Services;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lababa.Frontend.UserControls
{
    public partial class WeightServiceControl : UserControl
    {
        private readonly ApplicationSettings _appSettings;
        private readonly BindingList<WeightService> _weightServiceCatalog;
        public event EventHandler RemoveClicked;
        public event EventHandler DropDownValueChanged;
        public event EventHandler WeightChanged;
        public string ServiceName    
        {
            get
            {
                return cmbWeightServiceCatalog.SelectedItem is WeightService weightService ? weightService.ServiceName : string.Empty;
            }
        }

        public double Weight 
        { 
            get
            {
                return Convert.ToDouble(nudWeight.Value);
            }
        } 

        public decimal PricePerUnit 
        { 
            get
            {
                return cmbWeightServiceCatalog.SelectedItem is WeightService weightService ? weightService.PricePerUnit : 0;
            }
        }

        public WeightServiceControl()
        {
            InitializeComponent();

            _appSettings = new ApplicationSettingsService().LoadSettings();
            var catalog = new WeightServiceCatalogService().GetWeightServiceCatalog();
            _weightServiceCatalog = new BindingList<WeightService>(catalog);
            cmbWeightServiceCatalog.DataSource = _weightServiceCatalog;
            cmbWeightServiceCatalog.DisplayMember = "ServiceName"; 

            AddInteractiveEffectsRecursively(this);
            InitializeLabels();
        }

        public decimal GetTotalPrice()
        {
            if (cmbWeightServiceCatalog.SelectedItem is WeightService weightService)
            {
                return weightService.PricePerUnit * Convert.ToDecimal(nudWeight.Value);
            }
            return 0;
        }

        private void InitializeLabels()
        {
            WeightUnit defaultWeightUnit = _appSettings.DefaultWeightUnit;

            if (defaultWeightUnit == WeightUnit.Kilograms)
            {
                lblWeightUnit.Text = "Kilograms (kg)";
            }
            else
            {
                lblWeightUnit.Text = "Pounds (lb)";
            }
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
            if (cmbWeightServiceCatalog.SelectedItem is WeightService selectedService)
            {
                txtPricePerUnit.Text = $"{_appSettings.CurrencySymbol}{selectedService.PricePerUnit:F2}";
                DropDownValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void pbxRemove_Click(object sender, System.EventArgs e)
        {
            RemoveClicked?.Invoke(this, EventArgs.Empty); 
        }

        private void nudWeight_ValueChanged(object sender, EventArgs e)
        {
            WeightChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
