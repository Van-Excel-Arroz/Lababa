using Lababa.Backend.Models;
using Lababa.Backend.Services;
using Lababa.Frontend.UserControls.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;

namespace Lababa.Frontend.UserControls
{
    public partial class ShopInformationStep : UserControl, IWizardStep
    {
        private ApplicationSettings _appSettings;
        private ApplicationSettingsService _appSettingsService;
        private const string DEFAULT_RECEIPT_MESSAGE = "Thank you for choosing our laundry service!";

        public ShopInformationStep()
        {
            InitializeComponent();
        }

        public ShopInformationStep(ApplicationSettingsService appSettingsService)
        {
            InitializeComponent();
            _appSettingsService = appSettingsService;
            _appSettings = appSettingsService.LoadSettings();
        }

        private void ShopInformationStep_Load(object sender, System.EventArgs e)
        {
            if (!DesignMode && _appSettingsService == null)
            {
                _appSettingsService = Program.ServiceProvider.GetRequiredService<ApplicationSettingsService>();
                _appSettings = _appSettingsService.LoadSettings();
            }

            if (DesignMode || _appSettings == null) return;

            txtShopName.Text = _appSettings.ShopName;
            txtAddress.Text = _appSettings.Address;
            txtPhoneNumber.Text = _appSettings.PhoneNumber;
            txtReceiptMessage.Text = string.IsNullOrWhiteSpace(_appSettings.ReceiptMessage) ? DEFAULT_RECEIPT_MESSAGE : _appSettings.ReceiptMessage;

            switch (_appSettings.DefaultWeightUnit)
            {
                case WeightUnit.Kilograms:
                    rdoKilograms.Checked = true;
                    break;
                case WeightUnit.Pounds:
                    rdoPounds.Checked = true;
                    break;
                default:
                    rdoKilograms.Checked = true;
                    break;
            }

            if (_appSettings.CurrencySymbol != null && cmbCurrcencySymbol.Items.Contains(_appSettings.CurrencySymbol))
            {
                cmbCurrcencySymbol.SelectedItem = _appSettings.CurrencySymbol;
            }
            else
            {
                cmbCurrcencySymbol.SelectedIndex = 0;
            }
        }

        public void LoadStepData()
        {
            ShopInformationStep_Load(this, EventArgs.Empty);
        }

        public void SaveStepData()
        {
            _appSettings.ShopName = txtShopName.Text;
            _appSettings.Address = txtAddress.Text;
            _appSettings.PhoneNumber = txtPhoneNumber.Text;
            _appSettings.ReceiptMessage = txtReceiptMessage.Text;

            if (rdoKilograms.Checked)
            {
                _appSettings.DefaultWeightUnit = WeightUnit.Kilograms;
            }
            else
            {
                _appSettings.DefaultWeightUnit = WeightUnit.Pounds;

            }

            if (cmbCurrcencySymbol.SelectedItem != null)
            {
                _appSettings.CurrencySymbol = cmbCurrcencySymbol.SelectedItem.ToString();
            }

            _appSettingsService.SaveSettings(_appSettings);
        }

        public bool ValidateStep()
        {
            if (string.IsNullOrWhiteSpace(txtShopName.Text))
            {
                MessageBox.Show("Shop Name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtShopName.Text.Length > 50)
            {
                MessageBox.Show("Shop Name field must not be greater than 50", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtShopName.Focus();
                return false;
            }

            if (txtAddress.Text.Length > 100)
            {
                MessageBox.Show("Address field must not be greater than 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return false;
            }

            string pattern = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

            if (!Regex.IsMatch(txtPhoneNumber.Text, pattern))
            {
                MessageBox.Show("Please enter a valid phone number format \n(e.g., 123-456-7890).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                return false;
            }

            if (txtReceiptMessage.Text.Length > 100)
            {
                MessageBox.Show("Receipt message must not be greater than 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReceiptMessage.Focus();
                return false;
            }

            return true;
        }
    }
}
