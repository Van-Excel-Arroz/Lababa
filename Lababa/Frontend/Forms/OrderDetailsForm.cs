using Lababa.Backend.Models;
using Lababa.Backend.Services;
using Lababa.Frontend.UserControls;
using System.Windows.Forms;

namespace Lababa.Frontend.Forms
{
    public partial class OrderDetailsForm : Form
    {
        private readonly Order _order;
        private decimal _currentTotalAmount;
        private string _currencySymbol;

        public OrderDetailsForm(Order order, decimal currentTotalAmount, string currencySymbol)
        {
            InitializeComponent();
            _currentTotalAmount = currentTotalAmount;
            _currencySymbol = currencySymbol;
            _order = order;
            lblTotalAmount.Text = $"{_currencySymbol}{_currentTotalAmount:F2}";

            InitializeExistingServices();
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
            }
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
    }
}
