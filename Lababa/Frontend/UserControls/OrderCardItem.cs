using Lababa.Frontend.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace Lababa.Frontend.UserControls
{
    public partial class OrderCardItem : UserControl
    {
        public OrderCardItem()
        {
            InitializeComponent();
            SetupInteractiveEffects();
            AddDoubleClickToAllControls(this);
        }

        private void SetupInteractiveEffects()
        {
            AddEventsRecursively(this);

            cmsRightClickOptions.Opening += (s, e) =>
            {
                this.BackColor = Color.FromArgb(220, 235, 250);
            };

            cmsRightClickOptions.Closed += (s, e) =>
            {
                this.BackColor = Color.White;
            };
        }

        private void AddEventsRecursively(Control control)
        {
            control.MouseEnter += (s, e) =>
            {
                if (!cmsRightClickOptions.Visible)
                    this.BackColor = Color.FromArgb(245, 250, 255);
            };

            control.MouseLeave += (s, e) =>
            {
                if (!cmsRightClickOptions.Visible)
                    this.BackColor = Color.White;
            };

            control.ContextMenuStrip = cmsRightClickOptions;

            foreach (Control child in control.Controls)
            {
                AddEventsRecursively(child);
            }
        }

        private void AddDoubleClickToAllControls(Control parent)
        {
            parent.MouseDoubleClick += OrderCardItem_MouseDoubleClick;

            foreach (Control child in parent.Controls)
            {
                AddDoubleClickToAllControls(child);
            }
        }

        private void OrderCardItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var orderDetailsForm = new OrderDetailsForm();
            orderDetailsForm.Show();
        }

        private void viewDetailsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var orderDetailsForm = new OrderDetailsForm();
            orderDetailsForm.Show();
        }
    }
}
