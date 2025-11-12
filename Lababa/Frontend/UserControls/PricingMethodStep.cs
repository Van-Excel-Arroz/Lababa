using System.Windows.Forms;

namespace Lababa.Frontend.UserControls
{
    public partial class PricingMethodStep : UserControl
    {
        public PricingMethodStep()
        {
            InitializeComponent();
            cmbCurrcencySymbol.SelectedIndex = 0;
        }

        private void dgvWeightServices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvWeightServices.Columns["colRemoveImage"].Index && e.RowIndex >= 0)
            {
                e.Value = Properties.Resources.trash_2;
            }
        }

        private void dgvWeightServices_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvWeightServices.Columns["colRemoveImage"].Index)
            {
                dgvWeightServices.Cursor = Cursors.Hand;
            }
        }

        private void dgvWeightServices_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvWeightServices.Cursor = Cursors.Default;
        }

        private void dgvWeightServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvWeightServices.Columns["colRemoveImage"].Index)
            {
                dgvWeightServices.Rows.RemoveAt(e.RowIndex);
            }

        }
    }
}
