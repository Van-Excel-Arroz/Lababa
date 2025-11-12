using Lababa.Frontend.UserControls.Interfaces;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lababa.Frontend.UserControls
{
    public partial class ShopInformationStep : UserControl, IWizardStep
    {
        public ShopInformationStep()
        {
            InitializeComponent();
            cmbCurrcencySymbol.SelectedIndex = 0;
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
