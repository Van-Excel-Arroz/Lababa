using Lababa.Backend.Models;
using Lababa.Backend.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;

namespace Lababa.Frontend.Forms
{
    public partial class SearchOrderForm : Form
    {
        private readonly OrderService _orderService;
        private List<Order> _currentOrders;
        public event EventHandler OrdersUpdated;

        public SearchOrderForm(OrderService orderService)
        {
            InitializeComponent();
            _orderService = orderService;
            _currentOrders = new List<Order>();

            InitializeOrderStatus();
            InitializePaymentStatus();

            dtpFromDate.Value = DateTime.Today.AddMonths(-1);
            dtpToDate.Value = DateTime.Today;

            ApplyFilters();
        }

        private void LoadOrders()
        {
            var orderViewModels = _currentOrders.Select(order =>
            {
                return new OrderDisplayViewModel
                {
                    OrderId = order.OrderNumber,
                    Customer = order?.Customer.FullName ?? "N/A",
                    Phone = order?.Customer.PhoneNumber ?? "N/A",
                    OrderStatus = Regex.Replace(order.Status.ToString(), "([a-z])([A-Z])", "$1 $2"),
                    PaymentStatus = order.PaymentStatus.ToString(),
                    Total = order.TotalAmount,
                    DateCreated = order.DateCreated.ToString("MMM dd, yyyy hh:mm tt"),
                    Order = order
                };
            }).ToList();

            dgvOrders.DataSource = orderViewModels;

            if (dgvOrders.Columns["Order"] != null)
            {
                dgvOrders.Columns["Order"].Visible = false;
            }

            lblResult.Text = $"Found ({_currentOrders.Count}) Orders";
        }

        private void ApplyFilters()
        {
            _currentOrders = _orderService.SearchOrders(
                txtCustomerNameOrPhone.Text.Trim(),
                txtOrderNumber.Text.Trim(),
                (OrderStatus?)cmbOrderStatus.SelectedValue,
                (PaymentStatus?)cmbPaymentStatus.SelectedValue,
                dtpFromDate.Value.Date,
                dtpToDate.Value.Date
             );

            LoadOrders();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerNameOrPhone.Clear();
            txtOrderNumber.Clear();
            cmbOrderStatus.SelectedIndex = -1;
            cmbPaymentStatus.SelectedIndex = -1;
            dtpFromDate.Value = DateTime.Today.AddMonths(-1);
            dtpToDate.Value = DateTime.Today;

            ApplyFilters();
        }

        private void InitializeOrderStatus()
        {
            var orderStatuses = Enum.GetValues(typeof(OrderStatus)).Cast<OrderStatus>();

            var dataSource = orderStatuses.Select(os => new
            {
                Text = Regex.Replace(os.ToString(), "([a-z])([A-Z])", "$1 $2"),
                Value = os
            }).ToList();

            cmbOrderStatus.DataSource = dataSource;
            cmbOrderStatus.DisplayMember = "Text";
            cmbOrderStatus.ValueMember = "Value";
            cmbOrderStatus.SelectedIndex = -1;
        }

        private void InitializePaymentStatus()
        {
            var paymentStatuses = Enum.GetValues(typeof(PaymentStatus)).Cast<PaymentStatus>();

            var dataSource = paymentStatuses.Select(ps => new
            {
                Text = ps.ToString(),
                Value = ps
            }).ToList();

            cmbPaymentStatus.DataSource = dataSource;
            cmbPaymentStatus.DisplayMember = "Text";
            cmbPaymentStatus.ValueMember = "Value";
            cmbPaymentStatus.SelectedIndex = -1;
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvOrders.Columns["colView"] != null && e.ColumnIndex == dgvOrders.Columns["colView"].Index)
            {
                var viewModel = (OrderDisplayViewModel)dgvOrders.Rows[e.RowIndex].DataBoundItem;
                var orderDetailsForm = Program.ServiceProvider.GetRequiredService<OrderDetailsForm>();
                orderDetailsForm.LoadOrder(viewModel.Order.Id);
                orderDetailsForm.OrderUpdated += (sender2, e2) =>
                {
                    ApplyFilters();
                    OrdersUpdated?.Invoke(this, EventArgs.Empty);
                };
                orderDetailsForm.Show();
            }

            if (e.RowIndex >= 0 && dgvOrders.Columns["colDelete"] != null && e.ColumnIndex == dgvOrders.Columns["colDelete"].Index)
            {
                var viewModel = (OrderDisplayViewModel)dgvOrders.Rows[e.RowIndex].DataBoundItem;
                Order order = viewModel.Order;

                var result = MessageBox.Show(
                    $"Are you sure you want to delete order {order.OrderNumber}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    _orderService.DeleteOrder(order.Id);
                    ApplyFilters();
                    OrdersUpdated?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }

    public class OrderDisplayViewModel
    {
        public string OrderId { get; set; }
        public string Customer { get; set; }
        public string Phone { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }
        public decimal Total { get; set; }
        public string DateCreated { get; set; }
        public Order Order { get; set; } // Hidden column to store the full object
    }
}