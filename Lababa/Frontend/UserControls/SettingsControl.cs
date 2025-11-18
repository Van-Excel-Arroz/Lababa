using System;
using System.Windows.Forms;

namespace Lababa.Frontend.UserControls
{
    public partial class SettingsControl : UserControl
    {
        public event EventHandler SettingsChanged;
        public event EventHandler CancelClicked;

        public SettingsControl()
        {
            InitializeComponent();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            bool validShopInfo = shopInformationStep.ValidateStep();
            bool validWeightServices = weightServicesStep.ValidateStep();
            bool validItemServices = itemServicesStep.ValidateStep();

            if (validShopInfo) shopInformationStep.SaveStepData();
            if (validWeightServices) weightServicesStep.SaveStepData();
            if (validItemServices) itemServicesStep.SaveStepData();

            if (validShopInfo && validItemServices && validWeightServices)
            {
                MessageBox.Show("Settings save successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingsChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            shopInformationStep.LoadStepData();
            CancelClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
