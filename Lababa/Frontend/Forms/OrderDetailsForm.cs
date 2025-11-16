using Lababa.Backend.Models;
using Lababa.Backend.Services;
using Lababa.Frontend.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lababa.Frontend.Forms
{
    public partial class OrderDetailsForm : Form
    {
        private readonly Order _order;
        private decimal _currentTotalAmount;
        private string _currencySymbol;
        private List<WeightServiceControl> _initialWeightServiceControls;
        private List<ItemServiceControl> _initialItemServiceControls;
        public event EventHandler OrderUpdated;

        public OrderDetailsForm(Order order, decimal currentTotalAmount, string currencySymbol)
        {
            InitializeComponent();
            _currentTotalAmount = currentTotalAmount;
            _currencySymbol = currencySymbol;
            _order = order;
            _initialWeightServiceControls = new List<WeightServiceControl>();
            _initialItemServiceControls = new List<ItemServiceControl>();

            lblTotalAmount.Text = $"{_currencySymbol}{_currentTotalAmount:F2}";
            dtpDueDate.Value = _order.DueDate;

            
            InitializeExistingServices();
            InitializeCustomerDetails();
            InitializePaymentStatus();
            InitializeOrderStatus(); 
        }

        private void btnAddService_Click(object sender, System.EventArgs e)
        {
            if (tabServices.SelectedIndex == 0)
            {
                var weightServiceControl = new WeightServiceControl();
                weightServiceControl.RemoveClicked += (_, __) =>
                {
                    flpWeightServices.Controls.Remove(weightServiceControl);
                    RecalculateTotalAmount();
                };
                weightServiceControl.DropDownValueChanged += (_, __) => RecalculateTotalAmount();
                weightServiceControl.WeightChanged += (_, __) => RecalculateTotalAmount();
                weightServiceControl.Width = tabServices.Width - 50;
                flpWeightServices.Controls.Add(weightServiceControl);
            }
            else
            {
                var itemServiceControl = new ItemServiceControl();
                itemServiceControl.RemoveClicked += (_, __) =>
                {
                    flpItemServices.Controls.Remove(itemServiceControl);
                    RecalculateTotalAmount();
                };
                itemServiceControl.DropDownValueChanged += (_, __) => RecalculateTotalAmount();
                itemServiceControl.WeightChanged += (_, __) => RecalculateTotalAmount();
                flpItemServices.Controls.Add(itemServiceControl);
            }
        }

        private void InitializeExistingServices()
        {
            var orderWeightItems = new OrderWeightItemService().GetAllOrderWeightItems(_order.Id);

            foreach (var orderWeightItem in orderWeightItems)
            {
                var weightServiceControl = new WeightServiceControl(orderWeightItem);
                weightServiceControl.RemoveClicked += (_, __) =>
                {
                    flpWeightServices.Controls.Remove(weightServiceControl);
                    RecalculateTotalAmount();
                };
                weightServiceControl.DropDownValueChanged += (_, __) => RecalculateTotalAmount();
                weightServiceControl.WeightChanged += (_, __) => RecalculateTotalAmount();
                weightServiceControl.Width = tabServices.Width - 50;

                flpWeightServices.Controls.Add(weightServiceControl);
                _initialWeightServiceControls.Add(weightServiceControl);
            }

            var orderItemItems = new OrderItemItemService().GetAllOrderItemItems(_order.Id);

            foreach (var orderItemItem in orderItemItems)
            {
                var itemServiceControl = new ItemServiceControl(orderItemItem);
                itemServiceControl.RemoveClicked += (_, __) =>
                {
                    flpItemServices.Controls.Remove(itemServiceControl);
                    RecalculateTotalAmount();
                };
                itemServiceControl.DropDownValueChanged += (_, __) => RecalculateTotalAmount();
                itemServiceControl.WeightChanged += (_, __) => RecalculateTotalAmount();
                itemServiceControl.Width = tabServices.Width - 50;

                flpItemServices.Controls.Add(itemServiceControl);
                _initialItemServiceControls.Add(itemServiceControl);
            }
        }


        private void InitializeCustomerDetails()
        {
            var customer = new CustomerService().GetCustomerById(_order.CustomerId);
            lblCustomerName.Text = customer.FullName;
            lblPhoneNumber.Text = customer.PhoneNumber;
            lblAddress.Text = string.IsNullOrEmpty(customer.Address) ? "N/A" : customer.Address;
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

            cmbPaymentStatus.SelectedValue = _order.PaymentStatus;
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

            cmbOrderStatus.SelectedValue = _order.Status;
        }

        private void RecalculateTotalAmount()
        {
            decimal total = 0;
            foreach (WeightServiceControl control in flpWeightServices.Controls)
            {
                total += control.GetTotalPrice();
            }

            foreach (ItemServiceControl control in flpItemServices.Controls)
            {
                total += control.GetTotalPrice();
            }

            _currentTotalAmount = total;

            lblTotalAmount.Text = $"{_currencySymbol}{_currentTotalAmount:F2}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            var orderService = new OrderService();

            _order.DueDate = dtpDueDate.Value;
            _order.PaymentStatus = (PaymentStatus)cmbPaymentStatus.SelectedValue;
            _order.Status = (OrderStatus)cmbOrderStatus.SelectedValue;
            _order.TotalAmount = _currentTotalAmount;

            orderService.UpdateOrder(_order);

            var orderWeightItemService = new OrderWeightItemService();
            var orderItemItemService = new OrderItemItemService();

            foreach (WeightServiceControl control in flpWeightServices.Controls)
            {
                if (_initialWeightServiceControls.Contains(control)) continue;

                var weightService = control.GetWeightService;

                var orderWeightItem = new OrderWeightItem()
                {
                    ServiceId = weightService.Id,
                    ServiceNameAtOrderTime = weightService.ServiceName,
                    PricePerUnitAtOrderTime = weightService.PricePerUnit,
                    Weight = control.GetWeight,
                    OrderId = _order.Id,
                };

                orderWeightItemService.CreateOrderWeightItem(orderWeightItem);
            }

            foreach (ItemServiceControl control in flpItemServices.Controls)
            {
                if (_initialItemServiceControls.Contains(control)) continue;

                var itemService = control.GetItemService;

                var orderItemItem = new OrderItemItem()
                {
                    ServiceId = itemService.Id,
                    ItemNameAtOrderTime = itemService.ItemName,
                    PricePerPieceAtOrderTime = itemService.PricePerPiece,
                    Quantity = control.GetQuantity,
                    OrderId = _order.Id
                };

                orderItemItemService.CreateOrderItemItem(orderItemItem);
            }

            OrderUpdated?.Invoke(this, EventArgs.Empty);
            this.Close();
            MessageBox.Show("Order updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
