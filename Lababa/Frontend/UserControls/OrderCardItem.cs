using Lababa.Backend.Models;
using Lababa.Frontend.Events;
using Lababa.Frontend.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace Lababa.Frontend.UserControls
{
    public partial class OrderCardItem : UserControl
    {
        private readonly Order _order;
        private readonly ApplicationSettings _appSettings;
        public event EventHandler<OrderCardActionEventArgs> OrderActionRequested;

        public OrderCardItem(Order order, ApplicationSettings appSettings)
        {
            InitializeComponent();
            _order = order;
            _appSettings = appSettings;

            SetupInteractiveEffects();
            AddDoubleClickToAllControls(this);
        }

        private void OrderCardItem_Load(object sender, System.EventArgs e)
        {
            lblOrderNumber.Text = _order.OrderNumber;
            lblCustomerName.Text = _order.Customer?.FullName ?? "N/A";
            lblDueDate.Text = _order.DueDate.Date == DateTime.Today ? "Today" : _order.DueDate.ToString("MMM  dd, yyyy");
            lblTotalAmount.Text = $"{_appSettings.CurrencySymbol}{_order.TotalAmount}";
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
            var orderDetailsForm = Program.ServiceProvider.GetRequiredService<OrderDetailsForm>();
            orderDetailsForm.LoadOrder(_order.Id);
            orderDetailsForm.OrderUpdated += (_, __) => OrderActionRequested?.Invoke(this, new OrderCardActionEventArgs(_order, OrderCardActionType.Update));
            orderDetailsForm.Show();
        }

        private void viewDetailsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var orderDetailsForm = Program.ServiceProvider.GetRequiredService<OrderDetailsForm>();
            orderDetailsForm.LoadOrder(_order.Id);
            orderDetailsForm.OrderUpdated += (_, __) => OrderActionRequested?.Invoke(this, new OrderCardActionEventArgs(_order, OrderCardActionType.Update));
            orderDetailsForm.Show();
        }

        private void tsmiPrint_Click(object sender, EventArgs e)
        {
            var printOrderForm = new PrintOrderForm(_order, _appSettings);
            printOrderForm.Show();
        }

        private void tsmiPaid_Click(object sender, EventArgs e)
        {
            _order.PaymentStatus = PaymentStatus.Paid;
            OrderActionRequested?.Invoke(this, new OrderCardActionEventArgs(_order, OrderCardActionType.Update));
        }

        private void tsmiUnpaid_Click(object sender, System.EventArgs e)
        {
            _order.PaymentStatus = PaymentStatus.Unpaid;
            OrderActionRequested?.Invoke(this, new OrderCardActionEventArgs(_order, OrderCardActionType.Update));
        }

        private void tsmiRefunded_Click(object sender, EventArgs e)
        {
            _order.PaymentStatus = PaymentStatus.Refunded;
            OrderActionRequested?.Invoke(this, new OrderCardActionEventArgs(_order, OrderCardActionType.Update));
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Are you sure you want to delete {_order.OrderNumber}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                OrderActionRequested?.Invoke(this, new OrderCardActionEventArgs(_order, OrderCardActionType.Delete));
            }
        }

        private void tsmiPending_Click(object sender, EventArgs e)
        {
            _order.Status = OrderStatus.Pending;
            OrderActionRequested?.Invoke(this, new OrderCardActionEventArgs(_order, OrderCardActionType.Update));
        }

        private void tsmiInProgress_Click(object sender, EventArgs e)
        {
            _order.Status = OrderStatus.InProgress;
            OrderActionRequested?.Invoke(this, new OrderCardActionEventArgs(_order, OrderCardActionType.Update));
        }

        private void tsmiReady_Click(object sender, EventArgs e)
        {
            _order.Status = OrderStatus.Ready;
            OrderActionRequested?.Invoke(this, new OrderCardActionEventArgs(_order, OrderCardActionType.Update));
        }

        private void tsmiCompleted_Click(object sender, EventArgs e)
        {
            _order.Status = OrderStatus.Completed;
            OrderActionRequested?.Invoke(this, new OrderCardActionEventArgs(_order, OrderCardActionType.Update));
        }

        private void tsmiCancelled_Click(object sender, EventArgs e)
        {
            _order.Status = OrderStatus.Cancelled;
            OrderActionRequested?.Invoke(this, new OrderCardActionEventArgs(_order, OrderCardActionType.Update));
        }
    }
}
