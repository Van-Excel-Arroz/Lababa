using Lababa.Backend.Models;
using System.Windows.Forms;

namespace Lababa.Frontend.UserControls
{
    public partial class ItemServicePrintDetail : UserControl
    {
        public ItemServicePrintDetail(OrderItemItem orderItemItem, string currencySymbol)
        {
            InitializeComponent();

            lblItemName.Text = orderItemItem.ItemNameAtOrderTime;
            lblQuantity.Text = $"(x{orderItemItem.Quantity})";
            lblLineTotal.Text = $"{currencySymbol}{orderItemItem.PricePerPieceAtOrderTime * orderItemItem.Quantity:F2}";
        }
    }
}
