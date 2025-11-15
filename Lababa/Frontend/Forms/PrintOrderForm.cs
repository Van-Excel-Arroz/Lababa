using Lababa.Backend.Models;
using Lababa.Backend.Services;
using Lababa.Frontend.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lababa.Frontend.Forms
{
    public partial class PrintOrderForm : Form
    {
        private readonly Order _order;
        private readonly ApplicationSettings _appSettings;
        private readonly string _customerName;
        private readonly List<OrderWeightItem> _orderWeightItems;
        private readonly List<OrderItemItem> _orderItemItems;

        public PrintOrderForm(Order order, ApplicationSettings appSettings, string customerName)
        {
            InitializeComponent();
            _order = order;
            _appSettings = appSettings;
            _customerName = customerName;

            var orderWeightItemService = new OrderWeightItemService();
            var orderItemItemService = new OrderItemItemService();

            _orderWeightItems = orderWeightItemService.GetAllOrderWeightItems(_order.Id);
            _orderItemItems = orderItemItemService.GetAllOrderItemItems(_order.Id);

            InitializeOrderDetails();
            InitializeServices();
        }

        private void InitializeOrderDetails()
        {
            lblShopName.Text = _appSettings.ShopName;
            lblOrderId.Text = _order.OrderNumber;
            lblCustomerName.Text = _customerName;
            lblDateCreated.Text = _order.DateCreated.ToString("MMM dd, yyyy");
            lblDueDate.Text = _order.DueDate.ToString("MMM dd, yyyy");
            lblOrderStatus.Text = _order.Status.ToString();
            lblPaymentStatus.Text = _order.PaymentStatus.ToString();
            lblTotalAmount.Text = $"{_appSettings.CurrencySymbol}{_order.TotalAmount}";
        }

        private void InitializeServices()
        {
            foreach (var orderWeightItem in _orderWeightItems) 
            {
                var control = new WeightServicePrintDetail(orderWeightItem, _appSettings.DefaultWeightUnit, _appSettings.CurrencySymbol);
                control.Width = flpWeightServices.Width - 23;
                flpWeightServices.Controls.Add(control);
            }

            foreach (var orderItemItem in _orderItemItems)
            {
                var control = new ItemServicePrintDetail(orderItemItem, _appSettings.CurrencySymbol);
                control.Width = flpItemServices.Width - 23;
                flpItemServices.Controls.Add(control);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
