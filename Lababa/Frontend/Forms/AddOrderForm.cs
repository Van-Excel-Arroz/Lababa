using Lababa.Backend.Models;
using Lababa.Backend.Services;
using Lababa.Frontend.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Lababa.Frontend.Forms
{
    public partial class AddOrderForm : Form
    {
        private readonly ApplicationSettings _appSettings;
        private readonly CustomerService _customerService;
        private readonly OrderService _orderService;
        private readonly List<Customer> _allCustomers;
        public event EventHandler OrderCreated;

        public AddOrderForm()
        {
            InitializeComponent();

            _appSettings = new ApplicationSettingsService().LoadSettings();
            _customerService = new CustomerService();
            _orderService = new OrderService();
            _allCustomers = _customerService.GetAllCustomers();
            InitializeCustomers();
            lblTotalAmount.Text = "0";

          
        }

        private void InitializeCustomers()
        {
            BindingList<Customer> list = new BindingList<Customer>(_allCustomers);
            cmbCustomers.DataSource = list;
            cmbCustomers.DisplayMember = "FullNameAndPhone";
            cmbCustomers.SelectedItem = null;
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

                flpWeightServices.Controls.Add(weightServiceControl);

            } else
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

            lblTotalAmount.Text = $"{_appSettings.CurrencySymbol}{total:F2}";
        }

        private void btnCreateNewOrder_Click(object sender, System.EventArgs e)
        {
            decimal parsedTotalAmount = decimal.Parse(lblTotalAmount.Text);

            if (parsedTotalAmount <= 0)
            {
                MessageBox.Show("Please add at least one service with a valid amount before creating an order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer for the order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newOrder = new Order()
            {
                Status = OrderStatus.Pending,
                PaymentStatus = PaymentStatus.Unpaid,
                DueDate = dtpDueDate.Value,
                TotalAmount = parsedTotalAmount,
                CustomerId = cmbCustomers.SelectedValue is Customer selectedCustomer ? selectedCustomer.Id : System.Guid.Empty
            };

            _orderService.CreateOrder(newOrder);
            OrderCreated?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
