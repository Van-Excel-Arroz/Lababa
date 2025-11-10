using System;
using System.Windows.Forms;

namespace Lababa.Frontend.UserControls
{
    public partial class FinishWizardStep : UserControl
    {
        public event EventHandler GoNext;


        public FinishWizardStep()
        {
            InitializeComponent();
        }

        private void btnGoToDashboard_Click(object sender, EventArgs e)
        {
            GoNext.Invoke(this, EventArgs.Empty);
        }
    }
}
