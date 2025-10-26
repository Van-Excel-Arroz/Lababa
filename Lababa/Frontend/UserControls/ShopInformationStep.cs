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

            if (btnBackNext != null)
            {
                btnBackNext.GoNext += (object sender, EventArgs e) => GoNext?.Invoke(this, EventArgs.Empty);
                btnBackNext.GoBack += (object sender, EventArgs e) => GoBack?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("btnBackNext is missing on ShopInformationStep User Control.");
            }
        }


    }
}
