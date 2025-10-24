using Lababa.Frontend.Interfaces;
using System;
using System.Windows.Forms;

namespace Lababa.Frontend.UserControls
{
    public partial class ShopInformationStep : UserControl, IWizardStep
    {
        public event EventHandler GoNext;
        public event EventHandler GoBack;

        public ShopInformationStep()
        {
            InitializeComponent();
        }
    }
}
