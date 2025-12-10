using Lababa.Backend.Models;
using Lababa.Backend.Services;
using Lababa.Frontend.Events;
using Lababa.Frontend.UserControls;
using Microsoft.Extensions.DependencyInjection;

namespace Lababa.Frontend.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly OrderService _orderService;
        private readonly CustomerService _customerService;
        private ApplicationSettingsService _appSettingService;
        private ApplicationSettings _appSettings;

        public DashboardForm(OrderService orderService, CustomerService customerService, ApplicationSettingsService appSettingsService)
        {
            InitializeComponent();
            _orderService = orderService;
            _customerService = customerService;
            _appSettingService = appSettingsService;
            tlpOrdersTableView.Visible = true;
            settingsControl.Visible = false;
            tlpContainer.RowStyles[2] = new RowStyle(SizeType.Absolute, 0);
            AttachFlowLayoutPanelResizeHandlers();
            AttachedSettingsControlEvent();
            LoadSettings();
            LoadOrders();
        }

        private void LoadSettings()
        {
            _appSettings = _appSettingService.LoadSettings();
            lblShopName.Text = _appSettings.ShopName;
        }

        private void LoadOrders()
        {
            var orders = _orderService.GetAllOrders();

            lblTodaysRevenue.Text = $"{_appSettings.CurrencySymbol}{_orderService.CalculateOrdersTotalAmount(orders):F2}";
            lblTotalCustomers.Text = _customerService.GetAllCustomers().Count.ToString();
            lblTotalOrders.Text = orders.Count.ToString();
            string orderNumber = _orderService.GetRecentOrder()?.OrderNumber;
            lblRecentOrder.Text = orderNumber != null ? orderNumber : "N/A";

            flpPendingStatus.Controls.Clear();
            flpInProgressStatus.Controls.Clear();
            flpReadyStatus.Controls.Clear();
            flpCancelledStatus.Controls.Clear();

            foreach (var order in orders)
            {
                var orderCardItem = new OrderCardItem(order, _appSettings);
                orderCardItem.OrderActionRequested += HandleOrderCardAction;
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
                    case OrderStatus.Cancelled:
                        flpCancelledStatus.Controls.Add(orderCardItem);
                        desiredWidth = GetDesiredCardWidth(flpCancelledStatus);
                        orderCardItem.Width = desiredWidth;
                        break;
                    case OrderStatus.Completed:
                        flpCancelledStatus.Controls.Add(orderCardItem);
                        desiredWidth = GetDesiredCardWidth(flpCancelledStatus);
                        orderCardItem.Width = desiredWidth;
                        break;
                }
            }

            lblPendingCount.Text = flpPendingStatus.Controls.Count.ToString();
            lblInProgrgessCount.Text = flpInProgressStatus.Controls.Count.ToString();
            lblReadyCount.Text = flpReadyStatus.Controls.Count.ToString();
            lblCancelledCount.Text = flpCancelledStatus.Controls.Count.ToString();
        }

        private void HandleOrderCardAction(object sender, OrderCardActionEventArgs e)
        {
            switch (e.Action)
            {
                case OrderCardActionType.Update:
                    _orderService.UpdateOrder(e.Order);
                    break;
                case OrderCardActionType.Delete:
                    _orderService.DeleteOrder(e.Order.Id);
                    break;
            }

            LoadOrders();
        }

        private void AttachFlowLayoutPanelResizeHandlers()
        {
            SetupFlowLayoutPanelResize(flpPendingStatus);
            SetupFlowLayoutPanelResize(flpInProgressStatus);
            SetupFlowLayoutPanelResize(flpReadyStatus);
            SetupFlowLayoutPanelResize(flpCancelledStatus);
        }

        private void btnNewOrder_Click(object sender, System.EventArgs e)
        {
            var addOrderForm = Program.ServiceProvider.GetRequiredService<AddOrderForm>();
            addOrderForm.Show();
            addOrderForm.OrderCreated += (_, __) => LoadOrders();
        }

        private void btnSearchOrders_Click(object sender, System.EventArgs e)
        {
            var searchOrderForm = Program.ServiceProvider.GetRequiredService<SearchOrderForm>();
            searchOrderForm.OrdersUpdated += (_, __) => LoadOrders();
            searchOrderForm.Show();
        }

        private void btnCustomers_Click(object sender, System.EventArgs e)
        {
            var addCustomerForm = Program.ServiceProvider.GetRequiredService<AddCustomerForm>();
            addCustomerForm.CustomerUpdated += (_, __) => LoadOrders();
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

        private void AttachedSettingsControlEvent()
        {
            settingsControl.SettingsChanged += (_, __) =>
            {
                LoadSettings();
                LoadOrders();
                HandleSwitchTab();
            };

            settingsControl.CancelClicked += (_, __) => HandleSwitchTab();
        }

        private void HandleSwitchTab()
        {
            if (settingsControl.Visible == false && tlpOrdersTableView.Visible == true)
            {
                tlpOrdersTableView.Visible = false;
                settingsControl.Visible = true;
                tlpContainer.RowStyles[1] = new RowStyle(SizeType.Absolute, 0);
                tlpContainer.RowStyles[2] = new RowStyle(SizeType.Percent, 100);
            }
            else
            {
                tlpOrdersTableView.Visible = true;
                settingsControl.Visible = false;
                tlpContainer.RowStyles[2] = new RowStyle(SizeType.Absolute, 0);
                tlpContainer.RowStyles[1] = new RowStyle(SizeType.Percent, 100);
            }
        }

        private void btnSettings_Click(object sender, System.EventArgs e)
        {
            HandleSwitchTab();
        }

        private void lblShopName_Click(object sender, System.EventArgs e)
        {
            HandleSwitchTab();
        }
    }
}