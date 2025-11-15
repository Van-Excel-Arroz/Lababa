using Lababa.Backend.Models;
using Lababa.Backend.Services;
using Lababa.Frontend.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lababa.Frontend.UserControls
{
    public partial class OrderCardItem : UserControl
    {
        private readonly Order _order;
        private readonly Customer _customer;
        private readonly OrderService _orderService;
        private readonly string _currencySymbol;
        public event EventHandler OrderCardUpdated;

        public OrderCardItem(Order order)
        {
            InitializeComponent();
            _order = order;
            var customerService = new CustomerService();
            var appSettings = new ApplicationSettingsService().LoadSettings();
            _orderService = new OrderService();
            _customer = customerService.GetCustomerById(order.CustomerId);
            _currencySymbol = appSettings.CurrencySymbol;

            SetupInteractiveEffects();
            AddDoubleClickToAllControls(this);
        }

        private void OrderCardItem_Load(object sender, System.EventArgs e)
        {
            lblOrderNumber.Text = _order.OrderNumber;
            lblCustomerName.Text = _customer.FullName;
            lblDueDate.Text = _order.DueDate.ToString("MMM  dd, yyyy");
            lblTotalAmount.Text = $"{_currencySymbol}{_order.TotalAmount}";
            HandlePaymentStatus(_order.PaymentStatus);
            HandleOrderStatus(_order.Status);
        }

        private void HandlePaymentStatus(PaymentStatus paymentStatus)
        {
            switch (paymentStatus) 
            {
                case PaymentStatus.Paid:
                    lblPaymentStatus.Text = "Paid";
                    lblPaymentStatus.BackColor = Color.FromArgb(213, 247, 210);
                    lblPaymentStatus.ForeColor = Color.DarkGreen;
                    tsmiPaid.Checked = true;
                    break;
                case PaymentStatus.Unpaid:
                    lblPaymentStatus.Text = "Unpaid";
                    lblPaymentStatus.BackColor = Color.FromArgb(245, 215, 213);
                    lblPaymentStatus.ForeColor = Color.Firebrick;
                    tsmiUnpaid.Checked = true;
                    break;
                case PaymentStatus.Refunded:
                    lblPaymentStatus.Text = "Refunded";
                    lblPaymentStatus.BackColor = Color.LightGray;
                    lblPaymentStatus.ForeColor = Color.Black;
                    tsmiRefunded.Checked = true;
                    break;
            }
        }

        private void HandleOrderStatus(OrderStatus orderStatus)
        {
            switch (orderStatus)
            {
                case OrderStatus.Pending:
                    tsmiPending.Checked = true;
                    break;
                case OrderStatus.InProgress:
                    tsmiInProgress.Checked = true;
                    break;
                case OrderStatus.Ready:
                    tsmiReady.Checked = true;
                    break;
                case OrderStatus.Completed:
                    tsmiCompleted.Checked = true;
                    break;
                case OrderStatus.Cancelled:
                    tsmiCancelled.Checked = true;
                    break;
            }
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
            var orderDetailsForm = new OrderDetailsForm(_order, _order.TotalAmount, _currencySymbol);
            orderDetailsForm.OrderUpdated += (_, __) => OrderCardUpdated?.Invoke(this, EventArgs.Empty);
            orderDetailsForm.Show();
        }

        private void viewDetailsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var orderDetailsForm = new OrderDetailsForm(_order, _order.TotalAmount, _currencySymbol);
            orderDetailsForm.OrderUpdated += (_, __) => OrderCardUpdated?.Invoke(this, EventArgs.Empty);
            orderDetailsForm.Show();
        }

        private void tsmiPaid_Click(object sender, EventArgs e)
        {
            _order.PaymentStatus = PaymentStatus.Paid;
            _orderService.UpdateOrder(_order);
            OrderCardUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void tsmiUnpaid_Click(object sender, System.EventArgs e)
        {
            _order.PaymentStatus = PaymentStatus.Unpaid;
            _orderService.UpdateOrder(_order);
            OrderCardUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void tsmiRefunded_Click(object sender, EventArgs e)
        {
            _order.PaymentStatus = PaymentStatus.Refunded;
            _orderService.UpdateOrder(_order);
            OrderCardUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            _orderService.DeleteOrder(_order.Id);
            OrderCardUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void tsmiPending_Click(object sender, EventArgs e)
        {
            _order.Status = OrderStatus.Pending;
            _orderService.UpdateOrder(_order);
            OrderCardUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void tsmiInProgress_Click(object sender, EventArgs e)
        {
            _order.Status = OrderStatus.InProgress;
            _orderService.UpdateOrder(_order);
            OrderCardUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void tsmiReady_Click(object sender, EventArgs e)
        {
            _order.Status = OrderStatus.Ready;
            _orderService.UpdateOrder(_order);
            OrderCardUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void tsmiCompleted_Click(object sender, EventArgs e)
        {
            _order.Status = OrderStatus.Completed;
            _orderService.UpdateOrder(_order);
            OrderCardUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void tsmiCancelled_Click(object sender, EventArgs e)
        {
            _order.Status = OrderStatus.Cancelled;
            _orderService.UpdateOrder(_order);
            OrderCardUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
