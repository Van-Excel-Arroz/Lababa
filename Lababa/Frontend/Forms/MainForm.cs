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
                typeof(ShopInformationStep)
            };
        }

        private void OnGoNext(object sender, EventArgs e)
        {
            ShowStep(_currentStepIndex + 1);
        }

        private void OnGoBack(object sender, EventArgs e)
        {
            ShowStep(_currentStepIndex - 1);
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
                wizardStep.GoNext += OnGoNext;
                wizardStep.GoBack += OnGoBack;
            }

            tlpMainContent.Controls.Clear();
            stepControl.Anchor = AnchorStyles.None;
            tlpMainContent.Controls.Add(stepControl);
        }

    }
}
