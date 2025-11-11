using Lababa.Frontend.UserControls;
using System.Windows.Forms;

namespace Lababa.Frontend.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            for (int i = 1; i <= 15; i++)
            {
                var orderCardItem = new OrderCardItem();


                flpPendingStatus.Controls.Add(orderCardItem);

                flpPendingStatus.Resize += (s, e) =>
                {
                    foreach (Control c in flpPendingStatus.Controls)
                    {
                        c.Width = flpPendingStatus.ClientSize.Width - (flpPendingStatus.Padding.Horizontal + flpPendingStatus.Margin.Horizontal);
                    }
                };
            }
        }

        private void btnNewOrder_Click(object sender, System.EventArgs e)
        {
            var newOrderForm = new NewOrderForm();
            newOrderForm.Show();
        }
    }
}
