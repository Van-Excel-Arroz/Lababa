using System.ComponentModel;
using System.Windows.Forms;

namespace Lababa.Frontend.UserControls
{
    public partial class StepControlLabel : UserControl
    {
        private int _totalSteps;
        private int _index;
        private string _title;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int TotalSteps
        {
            get { return _totalSteps; }
            set
            {
                if (_totalSteps != value)
                {
                    _totalSteps = value;
                    UpdateLabelText();
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Index
        {
            get { return _index; }
            set
            {
                if (_index != value)
                {
                    _index = value;
                    UpdateLabelText();
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    UpdateLabelText();
                }
            }
        }

        public StepControlLabel()
        {
            InitializeComponent();
        }

        private void UpdateLabelText()
        {
            if (label != null)
            {
                label.Text = $"Step {Index} of {TotalSteps}: {Title}";
            }
        }

    }
}
