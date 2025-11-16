
using Lababa.Backend.Models;
using Lababa.Backend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lababa.Frontend.Forms
{
    public partial class SearchOrderForm : Form
    {
        private readonly List<Order> _orders;
        private readonly CustomerService _customerService;
        private string _currencySymbol;

        public SearchOrderForm(List<Order> orders, CustomerService customerService, string currencySymbol)
        {
            InitializeComponent();
            _orders = orders;
            _customerService = customerService;

            lblResult.Text = $"Found ({_orders.Count}) Orders";
            LoadOrders();
            InitializeOrderStatus();
            InitializePaymentStatus();
        }

        private void LoadOrders()
        {
            var orderViewModels = _orders.Select(order =>
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
                    dgvOrders.Rows.RemoveAt(e.RowIndex);
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
        public Order Order { get; set; }
    }

}
