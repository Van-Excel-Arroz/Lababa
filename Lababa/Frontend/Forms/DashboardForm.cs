using Lababa.Backend.Services;
using Lababa.Backend.Models;
using Lababa.Frontend.UserControls;
using System.Windows.Forms;

namespace Lababa.Frontend.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly OrderService _orderService;

        public DashboardForm()
        {
            InitializeComponent();
            _orderService = new OrderService();
            AttachFlowLayoutPanelResizeHandlers();
            LoadOrders();
        }

        private void LoadOrders()
        {
            var orders = _orderService.GetAllOrders();

            ClearFlowLayoutPanels();

            foreach (var order in orders)
            {
                var orderCardItem = new OrderCardItem(order);

                orderCardItem.ToolStripMenuItemClicked += (_, __) => LoadOrders();

                switch (order.Status)
                {
                    case OrderStatus.Pending:
                        flpPendingStatus.Controls.Add(orderCardItem);
                        break;
                    case OrderStatus.InProgress:
                        flpInProgressStatus.Controls.Add(orderCardItem);
                        break;
                    case OrderStatus.Ready:
                        flpReadyStatus.Controls.Add(orderCardItem);
                        break;
                    case OrderStatus.Completed:
                        flpCompletedStatus.Controls.Add(orderCardItem);
                        break;
                    case OrderStatus.Cancelled:
                        break;
                }
            }
        }

        private void AttachFlowLayoutPanelResizeHandlers()
        {
            SetupFlowLayoutPanelResize(flpPendingStatus);
            SetupFlowLayoutPanelResize(flpInProgressStatus);
            SetupFlowLayoutPanelResize(flpReadyStatus);
            SetupFlowLayoutPanelResize(flpCompletedStatus);
        }

        private void btnNewOrder_Click(object sender, System.EventArgs e)
        {
            var addOrderForm = new AddOrderForm();
            addOrderForm.Show();
            addOrderForm.OrderCreated += (_, __) => LoadOrders();
        }

        private void btnSearchOrders_Click(object sender, System.EventArgs e)
        {
            var searchOrderForm = new SearchOrderForm();
            searchOrderForm.Show();
        }

        private void btnCustomers_Click(object sender, System.EventArgs e)
        {
            var addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
        }

        public void ClearFlowLayoutPanels()
        {
            flpPendingStatus.Controls.Clear();
            flpInProgressStatus.Controls.Clear();
            flpReadyStatus.Controls.Clear();
            flpCompletedStatus.Controls.Clear();
        }

        private void SetupFlowLayoutPanelResize(FlowLayoutPanel flp)
        {
            flp.Resize += (s, e) =>
            {
                int desiredWidth = GetDesiredCardWidth(flp);

                if (desiredWidth < 0) desiredWidth = 0;

                foreach (Control c in flp.Controls)
                {
                    if (c is OrderCardItem orderCard)
                    {
                        orderCard.Width = desiredWidth;
                    }
                }
            };
        }

        private int GetDesiredCardWidth(FlowLayoutPanel flp)
        {
            int width = flp.ClientSize.Width;

            if (flp.VerticalScroll.Visible)
            {
                width -= SystemInformation.VerticalScrollBarWidth;
            }

            width -= (flp.Padding.Horizontal + flp.Margin.Horizontal);

            width -= 1;

            return width > 0 ? width : 0;
        }

    }
}