using System.Windows.Forms;

namespace Lababa.Frontend.UserControls
{
    public partial class StepControlLabel : UserControl
    {
        public int TotalSteps { get; set; }
        public int Index { get; set; }
        public string Title { get; set; }

        public StepControlLabel()
        {
            InitializeComponent();
            label.Text = $"Step {Index} of {TotalSteps}: {Title}";
        }
    }
}
