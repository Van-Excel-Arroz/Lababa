using System;
using System.Windows.Forms;

namespace Lababa.Frontend.UserControls
{
    public partial class BackNextButtons : UserControl
    {
        public event EventHandler GoNext;
        public event EventHandler GoBack;

        public BackNextButtons()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GoBack.Invoke(this, EventArgs.Empty);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GoNext.Invoke(this, EventArgs.Empty);
        }
    }
}
