using Lababa.Backend.Models;
using Lababa.Backend.Services;
using Lababa.Frontend.UserControls;

namespace Lababa.Frontend.Forms
{
    public partial class OrderDetailsForm : Form
    {
        private Order _order;
        private decimal _currentTotalAmount;
        private string _currencySymbol;
        private List<WeightServiceControl> _initialWeightServiceControls;
        private List<ItemServiceControl> _initialItemServiceControls;
        private readonly CustomerService _customerService;
        private readonly OrderService _orderService;
        private readonly OrderWeightItemService _orderWeightItemService;
        private readonly OrderItemItemService _orderItemItemService;
        public event EventHandler OrderUpdated;


        public OrderDetailsForm(
            CustomerService customerService, 
            OrderService orderService, 
            ApplicationSettingsService appSettingsService, 
            OrderWeightItemService weightItemService, 
            OrderItemItemService orderItemservice)
        {
            InitializeComponent();
            _currentTotalAmount = _order.TotalAmount;
            _currencySymbol = appSettingsService.LoadSettings().CurrencySymbol;
            _customerService = customerService;
            _orderService = orderService;
            _initialWeightServiceControls = new List<WeightServiceControl>();
            _initialItemServiceControls = new List<ItemServiceControl>();
            _orderWeightItemService = weightItemService;
            _orderItemItemService = orderItemservice;

            lblTotalAmount.Text = $"{_currencySymbol}{_currentTotalAmount:F2}";
            lblCreatedDate.Text = _order.DateCreated.ToString("MMM dd, yyyy");
            dtpDueDate.Value = _order.DueDate;
            
            InitializeExistingServices();
            InitializeCustomerDetails();
            InitializePaymentStatus();
            InitializeOrderStatus(); 
        }

        public void LoadOrder(Guid orderId)
        {
            _order = _orderService.GetOrderById(orderId);
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
            RecalculateTotalAmount();
        }

        private void InitializeExistingServices()
        {
            var orderWeightItems = _order.WeightItems;


            foreach (var orderWeightItem in orderWeightItems)
            {
                var weightServiceControl = new WeightServiceControl(orderWeightItem);
                weightServiceControl.RemoveClicked += (_, __) =>
                {
                    flpWeightServices.Controls.Remove(weightServiceControl);
                    _orderWeightItemService.DeleteOrderWeightItem(orderWeightItem.Id);
                    RecalculateTotalAmount();
                };
                weightServiceControl.DropDownValueChanged += (_, __) => RecalculateTotalAmount();
                weightServiceControl.WeightChanged += (_, __) => RecalculateTotalAmount();
                weightServiceControl.Width = tabServices.Width - 50;

                flpWeightServices.Controls.Add(weightServiceControl);
                _initialWeightServiceControls.Add(weightServiceControl);
            }

            var orderItemItems = _orderItemItemService.GetAllOrderItemItems(_order.Id);

            foreach (var orderItemItem in orderItemItems)
            {
                var itemServiceControl = new ItemServiceControl(orderItemItem);
                itemServiceControl.RemoveClicked += (_, __) =>
                {
                    flpItemServices.Controls.Remove(itemServiceControl);
                    _orderItemItemService.DeleteOrderItemItem(orderItemItem.Id);
                    RecalculateTotalAmount();
                };
                itemServiceControl.DropDownValueChanged += (_, __) => RecalculateTotalAmount();
                itemServiceControl.WeightChanged += (_, __) => RecalculateTotalAmount();
                itemServiceControl.Width = tabServices.Width - 50;

                flpItemServices.Controls.Add(itemServiceControl);
                _initialItemServiceControls.Add(itemServiceControl);
            }
            RecalculateTotalAmount();
        }


        private void InitializeCustomerDetails()
        {
            var customer = _customerService.GetCustomerById(_order.CustomerId);
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

            var dataSource = orderStatuses.Select(ps => new
            {
                Text = ps.ToString(),
                Value = ps
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
            _order.DueDate = dtpDueDate.Value;
            _order.PaymentStatus = (PaymentStatus)cmbPaymentStatus.SelectedValue;
            _order.Status = (OrderStatus)cmbOrderStatus.SelectedValue;
            _order.TotalAmount = _currentTotalAmount;

            _orderService.UpdateOrder(_order);

  
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

                _orderWeightItemService.CreateOrderWeightItem(orderWeightItem);
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

                _orderItemItemService.CreateOrderItemItem(orderItemItem);
            }

            OrderUpdated?.Invoke(this, EventArgs.Empty);
            this.Close();
            MessageBox.Show("Order updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
