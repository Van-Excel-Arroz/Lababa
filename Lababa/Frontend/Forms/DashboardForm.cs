using Lababa.Backend.Models;
using Lababa.Backend.Services;
using Lababa.Frontend.UserControls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lababa.Frontend.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly OrderService _orderService;
        private readonly CustomerService _customerService;
        private readonly ApplicationSettings _appSettings;

        public DashboardForm()
        {
            InitializeComponent();
            _orderService = new OrderService();
            _appSettings = new ApplicationSettingsService().LoadSettings();
            _customerService = new CustomerService();
            AttachFlowLayoutPanelResizeHandlers();
            LoadOrders();
        }

        private void LoadOrders()
        {
            var orders = _orderService.GetAllOrders();

            lblTodaysRevenue.Text = $"{_appSettings.CurrencySymbol}{_orderService.CalculateOrdersTotalAmount(orders):F2}";
            lblTotalCustomers.Text = _customerService.GetAllCustomers().Count.ToString();
            lblTotalOrders.Text = orders.Count.ToString();
            lblRecentOrder.Text = _orderService.GetRecentOrder().OrderNumber;

            flpPendingStatus.Controls.Clear();
            flpInProgressStatus.Controls.Clear();
            flpReadyStatus.Controls.Clear();
            flpCompletedStatus.Controls.Clear();

            foreach (var order in orders)
            {
                var orderCardItem = new OrderCardItem(order);

                orderCardItem.ToolStripMenuItemClicked += (_, __) => LoadOrders();
                int desiredWidth = 0;

                switch (order.Status)
                {
                    case OrderStatus.Pending:
                        flpPendingStatus.Controls.Add(orderCardItem);
                        desiredWidth = GetDesiredCardWidth(flpPendingStatus);
                        orderCardItem.Width = desiredWidth;
                        break;
                    case OrderStatus.InProgress:
                        flpInProgressStatus.Controls.Add(orderCardItem);
                        desiredWidth = GetDesiredCardWidth(flpInProgressStatus);
                        orderCardItem.Width = desiredWidth;
                        break;
                    case OrderStatus.Ready:
                        flpReadyStatus.Controls.Add(orderCardItem);
                        desiredWidth = GetDesiredCardWidth(flpReadyStatus);
                        orderCardItem.Width = desiredWidth;
                        break;
                    case OrderStatus.Completed:
                        flpCompletedStatus.Controls.Add(orderCardItem);
                        desiredWidth = GetDesiredCardWidth(flpCompletedStatus);
                        orderCardItem.Width = desiredWidth;
                        break;
                    case OrderStatus.Cancelled:
                        break;
                }
            }

            lblPendingCount.Text = flpPendingStatus.Controls.Count.ToString();
            lblInProgrgessCount.Text = flpInProgressStatus.Controls.Count.ToString();
            lblReadyCount.Text = flpReadyStatus.Controls.Count.ToString();
            lblCompletedCount.Text = flpCompletedStatus.Controls.Count.ToString();

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

        private void SetupFlowLayoutPanelResize(FlowLayoutPanel flp)
        {
            flp.Padding = new Padding(10, 0, 10, 0);

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
            width -= 4;


            return width > 0 ? width : 0;
        }
    }
}