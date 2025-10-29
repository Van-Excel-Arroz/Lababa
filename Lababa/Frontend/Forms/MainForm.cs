using Lababa.Frontend.Interfaces;
using Lababa.Frontend.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lababa
{
    public partial class MainForm : Form
    {
        private List<Type> _wizardSteps;
        private int _currentStepIndex = -1;

        public MainForm()
        {
            InitializeComponent();
            InitializeWizard();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowStep(0);
        }

        private void InitializeWizard()
        {
            _wizardSteps = new List<Type>
            {
                typeof(WelcomeStepControl),
                typeof(ShopInformationStep),
                typeof(PricingMethodStep)
            };
        }

        private void ShowStep(int index)
        {
            if (index < 0 || index >= _wizardSteps.Count) return;

            _currentStepIndex = index;

            var stepType = _wizardSteps[_currentStepIndex];
            UserControl stepControl = (UserControl)Activator.CreateInstance(stepType);

            IWizardStep wizardStep = stepControl as IWizardStep;
            if (wizardStep != null)
            {
                wizardStep.GoNext += (object sender, EventArgs e) => ShowStep(_currentStepIndex + 1);
                wizardStep.GoBack += (object sender, EventArgs e) => ShowStep(_currentStepIndex - 1);
            }

            tlpMainContent.Controls.Clear();
            stepControl.Dock = DockStyle.Fill;
            tlpMainContent.Controls.Add(stepControl);
        }
    }
}
