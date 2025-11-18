
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lababa.Frontend.Forms
{
    public partial class SearchOrderForm : Form
    {
        private readonly List<Order> _allOrders;
        private List<Order> _filteredOrders;
        private readonly CustomerService _customerService;
        private readonly OrderService _orderService;
        private string _currencySymbol;
        public event EventHandler OrdersUpdated;

        public SearchOrderForm(List<Order> orders, CustomerService customerService, string currencySymbol)
        {
            InitializeComponent();
            _allOrders = orders;
            _customerService = customerService;
            _currencySymbol = currencySymbol;
            _filteredOrders = new List<Order>(_allOrders);
            _orderService = new OrderService();

            lblResult.Text = $"Found ({_allOrders.Count}) Orders";
            LoadOrders();
            InitializeOrderStatus();
            InitializePaymentStatus();

            dtpFromDate.Value = DateTime.Today.AddMonths(-1); 
            dtpToDate.Value = DateTime.Today;
        }

        private void LoadOrders()
        {
            var orderViewModels = _filteredOrders.Select(order =>
            {
                var customer = _customerService.GetCustomerById(order.CustomerId);

                return new OrderDisplayViewModel
                {
                    OrderId = order.OrderNumber,
                    Customer = customer?.FullName ?? "Unknown",
                    Phone = customer?.PhoneNumber ?? "N/A",
                    OrderStatus = Regex.Replace(order.Status.ToString(), "([a-z])([A-Z])", "$1 $2"),
                    PaymentStatus = order.PaymentStatus.ToString(),
                    Total = order.TotalAmount,
                    DateCreated = order.DateCreated.ToString("MMM dd, yyyy hh:mm tt"),
                    Order = order
                };
            }).ToList();

            dgvOrders.DataSource = orderViewModels;
            dgvOrders.Columns["Order"].Visible = false;

            lblResult.Text = $"Found ({_filteredOrders.Count}) Orders";
        }

        private void ApplyFilters()
        {
            IEnumerable<Order> query = _allOrders;

            if (!string.IsNullOrWhiteSpace(txtCustomerNameOrPhone.Text))
            {
                string searchTerm = txtCustomerNameOrPhone.Text.Trim().ToLower();
                query = query.Where(order =>
                {
                    var customer = _customerService.GetCustomerById(order.CustomerId);
                    return (customer != null && customer.FullName.ToLower().Contains(searchTerm)) ||
                           (customer != null && customer.PhoneNumber.ToLower().Contains(searchTerm));
                });
            }

            if (!string.IsNullOrWhiteSpace(txtOrderNumber.Text))
            {
                string orderNumberSearchTerm = txtOrderNumber.Text.Trim().ToLower();
                query = query.Where(order => order.OrderNumber.ToLower().Contains(orderNumberSearchTerm));
            }

            if (cmbOrderStatus.SelectedValue != null && cmbOrderStatus.SelectedIndex != -1)
            {
                OrderStatus selectedStatus = (OrderStatus)cmbOrderStatus.SelectedValue;
                query = query.Where(order => order.Status == selectedStatus);
            }

            if (cmbPaymentStatus.SelectedValue != null && cmbPaymentStatus.SelectedIndex != -1)
            {
                PaymentStatus selectedPaymentStatus = (PaymentStatus)cmbPaymentStatus.SelectedValue;
                query = query.Where(order => order.PaymentStatus == selectedPaymentStatus);
            }

        private void ApplyFilters()
        {
            IEnumerable<Order> query = _allOrders; 

            if (!string.IsNullOrWhiteSpace(txtCustomerNameOrPhone.Text))
            {
                string searchTerm = txtCustomerNameOrPhone.Text.Trim().ToLower();
                query = query.Where(order =>
                {
                    var customer = _customerService.GetCustomerById(order.CustomerId);
                    return (customer != null && customer.FullName.ToLower().Contains(searchTerm)) ||
                           (customer != null && customer.PhoneNumber.ToLower().Contains(searchTerm));
                });
            }

            if (!string.IsNullOrWhiteSpace(txtOrderNumber.Text))
            {
                string orderNumberSearchTerm = txtOrderNumber.Text.Trim().ToLower();
                query = query.Where(order => order.OrderNumber.ToLower().Contains(orderNumberSearchTerm));
            }

            if (cmbOrderStatus.SelectedValue != null && cmbOrderStatus.SelectedIndex != -1)
            {
                OrderStatus selectedStatus = (OrderStatus)cmbOrderStatus.SelectedValue;
                query = query.Where(order => order.Status == selectedStatus);
            }
            
            if (cmbPaymentStatus.SelectedValue != null && cmbPaymentStatus.SelectedIndex != -1)
            {
                PaymentStatus selectedPaymentStatus = (PaymentStatus)cmbPaymentStatus.SelectedValue;
                query = query.Where(order => order.PaymentStatus == selectedPaymentStatus);
            }

            DateTime fromDate = dtpFromDate.Value.Date; 
            DateTime toDate = dtpToDate.Value.Date.AddDays(1).AddSeconds(-1);

            query = query.Where(order => order.DateCreated >= fromDate && order.DateCreated <= toDate);


            _filteredOrders = query.ToList();
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

            _filteredOrders = new List<Order>(_allOrders);
            LoadOrders(); 
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtCustomerNameOrPhone.Clear();
            txtOrderNumber.Clear(); 
            cmbOrderStatus.SelectedIndex = -1;
            cmbPaymentStatus.SelectedIndex = -1;
            dtpFromDate.Value = DateTime.Today.AddMonths(-1);
            dtpToDate.Value = DateTime.Today;

            _filteredOrders = new List<Order>(_allOrders);
            LoadOrders(); 
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

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvOrders.Columns["colView"].Index)
            {
                var viewModel = (OrderDisplayViewModel)dgvOrders.Rows[e.RowIndex].DataBoundItem;
                var orderDetailsForm = new OrderDetailsForm(viewModel.Order, viewModel.Total, _currencySymbol);
                orderDetailsForm.Show();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvOrders.Columns["colDelete"].Index)
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
                    _allOrders.Remove(order);
                    _filteredOrders.Remove(order);
                    LoadOrders();
                    OrdersUpdated?.Invoke(this, EventArgs.Empty);
                }
            }
>>>>>>> fa0b83e7288ca9b2544f7dcffbc6bd543e81a39e

        }
    }
}
