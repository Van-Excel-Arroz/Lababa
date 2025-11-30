namespace Lababa.Frontend.UserControls
{
    public partial class FinishWizardStep : UserControl
    {
        public event EventHandler WizardCompleted;
        public event EventHandler GoBack;


        public FinishWizardStep()
        {
            InitializeComponent();
        }

        private void btnGoToDashboard_Click(object sender, EventArgs e)
        {
            WizardCompleted?.Invoke(this, EventArgs.Empty);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            GoBack?.Invoke(this, EventArgs.Empty);
        }
    }
}
