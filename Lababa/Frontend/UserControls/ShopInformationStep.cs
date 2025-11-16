using Lababa.Backend.Models;
using Lababa.Backend.Services;
using Lababa.Frontend.UserControls.Interfaces;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lababa.Frontend.UserControls
{
    public partial class ShopInformationStep : UserControl, IWizardStep
    {
        private readonly ApplicationSettingsService _appSettingsService;
        private const string DEFAULT_RECEIPT_MESSAGE = "Thank you for choosing our laundry service!";

        public ShopInformationStep()
        {
            InitializeComponent();
            _appSettingsService = new ApplicationSettingsService();
        }

        private void ShopInformationStep_Load(object sender, System.EventArgs e)
        {
            var appSettings = _appSettingsService.LoadSettings();
            txtShopName.Text = appSettings.ShopName;
            txtAddress.Text = appSettings.Address;
            txtPhoneNumber.Text = appSettings.PhoneNumber;
            txtReceiptMessage.Text = string.IsNullOrWhiteSpace(appSettings.ReceiptMessage) ? DEFAULT_RECEIPT_MESSAGE : appSettings.ReceiptMessage;

            switch (appSettings.DefaultWeightUnit)
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

            if (appSettings.CurrencySymbol != null && cmbCurrcencySymbol.Items.Contains(appSettings.CurrencySymbol))
            {
                cmbCurrcencySymbol.SelectedItem = appSettings.CurrencySymbol;
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
            var settings = _appSettingsService.LoadSettings();
            settings.ShopName = txtShopName.Text;
            settings.Address = txtAddress.Text;
            settings.PhoneNumber = txtPhoneNumber.Text;
            settings.ReceiptMessage = txtReceiptMessage.Text;

            if (rdoKilograms.Checked)
            {
                settings.DefaultWeightUnit = WeightUnit.Kilograms;
            }
            else
            {
                settings.DefaultWeightUnit = WeightUnit.Pounds;

            }

            if (cmbCurrcencySymbol.SelectedItem != null)
            {
                settings.CurrencySymbol = cmbCurrcencySymbol.SelectedItem.ToString();
            }

            _appSettingsService.SaveSettings(settings);
        }

        public bool ValidateStep()
        {
            if (string.IsNullOrWhiteSpace(txtShopName.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("You can't leave all the fields empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            return true;
        }
    }
}
