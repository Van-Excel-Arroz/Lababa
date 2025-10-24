using Lababa.Frontend.Interfaces;
using System;
using System.Windows.Forms;

namespace Lababa.Frontend.UserControls
{
    public partial class WelcomeStepControl : UserControl, IWizardStep
    {
        public event EventHandler GoNext;
        public event EventHandler GoBack;

        public WelcomeStepControl()
        {
            InitializeComponent();
        }

        private void btnGetStarted_Click(object sender, System.EventArgs e)
        {
            GoNext?.Invoke(this, EventArgs.Empty);
        }
    }
}
