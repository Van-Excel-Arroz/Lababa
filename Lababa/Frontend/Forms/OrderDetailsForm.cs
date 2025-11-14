using System.Windows.Forms;
using Lababa.Backend.Models;

namespace Lababa.Frontend.Forms
{
    public partial class OrderDetailsForm : Form
    {
        private readonly Order _order;
        public OrderDetailsForm(Order order)
        {
            InitializeComponent();
            _order = order;
            Text = $"Order Details - {_order.OrderNumber}";
        }
    }
}
