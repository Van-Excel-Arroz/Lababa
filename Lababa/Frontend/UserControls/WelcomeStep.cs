namespace Lababa.Frontend.UserControls
{
    public partial class WelcomeStep : UserControl
    {
        public event EventHandler GoNext;

        public WelcomeStep()
        {
            InitializeComponent();
        }

        private void btnGetStarted_Click(object sender, System.EventArgs e)
        {
            GoNext?.Invoke(this, EventArgs.Empty);
        }
    }
}
