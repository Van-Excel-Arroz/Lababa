using Lababa.Frontend.Forms;
using Lababa.Frontend.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lababa
{
    public partial class WizardForm : Form
    {
        private List<WizardStepInfo> _wizardSteps;
        private int _currentStepIndex = -1;
        private TableLayoutPanel _tlpStepDetails;
        private Control _currentControl;
        private StepControlLabel _stepControlLabel;
        private BackNextButtons _btnBackNext;

        private const int HEADER_ROW = 0;
        private const int CONTENT_ROW = 1;
        private const int FOOTER_ROW = 2;

        public WizardForm()
        {
            InitializeComponent();
            InitializeWizard();

            _tlpStepDetails = new TableLayoutPanel();
            _stepControlLabel = new StepControlLabel();
            _btnBackNext = new BackNextButtons();

            _btnBackNext.GoNext += (_, __) => ShowStep(_currentStepIndex + 1);
            _btnBackNext.GoBack += (_, __) => ShowStep(_currentStepIndex - 1);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _tlpStepDetails.RowStyles.Clear();

            _tlpStepDetails.RowCount = 3;
            _tlpStepDetails.ColumnCount = 1;
            _tlpStepDetails.Dock = DockStyle.Fill;
            _tlpStepDetails.RowStyles.Add(new RowStyle(SizeType.AutoSize, 100f));
            _tlpStepDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _tlpStepDetails.RowStyles.Add(new RowStyle(SizeType.AutoSize, 100F));

            _stepControlLabel.Dock = DockStyle.Left;
            _tlpStepDetails.Controls.Add(_stepControlLabel, 0, HEADER_ROW);

            _btnBackNext.Dock = DockStyle.Bottom;
            _tlpStepDetails.Controls.Add(_btnBackNext, 0, FOOTER_ROW);

            tlpMainContent.Controls.Add(_tlpStepDetails);
            _stepControlLabel.TotalSteps = _wizardSteps.Count - 1;

            ShowStep(0);
        }

        private void InitializeWizard()
        {
            _wizardSteps = new List<WizardStepInfo>
            {
                new WizardStepInfo {StepType = typeof(WelcomeStepControl), Title = "Welcome"},
                new WizardStepInfo {StepType = typeof(ShopInformationStep), Title = "Shop Information"},
                new WizardStepInfo {StepType = typeof(PricingMethodStep), Title = "Pricing Settings"}
            };
        }

        private void ShowStep(int index)
        {
            if (index < 0 || index >= _wizardSteps.Count) return;

            if (_currentControl != null) _tlpStepDetails.Controls.Remove(_currentControl);

            _currentStepIndex = index;

            if (index == 0)
            {
                _stepControlLabel.Visible = false;
                _btnBackNext.Visible = false;
                var currentStepInfo = _wizardSteps[_currentStepIndex];

                var stepType = currentStepInfo.StepType;
                WelcomeStepControl welcomeStepControl = (WelcomeStepControl)Activator.CreateInstance(stepType);

                welcomeStepControl.Dock = DockStyle.Fill;
                _tlpStepDetails.Controls.Add(welcomeStepControl, 0, CONTENT_ROW);
                _currentControl = welcomeStepControl;

                welcomeStepControl.GoNext += (_, __) => ShowStep(1);
            }
            else
            {
                _stepControlLabel.Visible = true;
                _btnBackNext.Visible = true;
                var currentStepInfo = _wizardSteps[_currentStepIndex];

                _stepControlLabel.Index = index;
                _stepControlLabel.Title = currentStepInfo.Title;

                var stepType = currentStepInfo.StepType;
                UserControl newStepControl = (UserControl)Activator.CreateInstance(stepType);

                newStepControl.Dock = DockStyle.Fill;
                _tlpStepDetails.Controls.Add(newStepControl, 0, CONTENT_ROW);
                _currentControl = newStepControl;
            }
        }
    }
}
