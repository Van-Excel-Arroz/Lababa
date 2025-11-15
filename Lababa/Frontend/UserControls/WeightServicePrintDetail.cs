
using Lababa.Backend.Models;
using System.Windows.Forms;

namespace Lababa.Frontend.UserControls
{
    public partial class WeightServicePrintDetail : UserControl
    {
        public WeightServicePrintDetail(OrderWeightItem orderWeightItem, WeightUnit defaultWeightUnit, string currencySymbol)
        {
            InitializeComponent();

            string weightUnitSymbol = defaultWeightUnit == WeightUnit.Kilograms ? "kg" : "lb";

            lblServiceName.Text = orderWeightItem.ServiceNameAtOrderTime;
            lblWeight.Text = $"({orderWeightItem.Weight} {weightUnitSymbol})";
            lblLineTotal.Text = $"{currencySymbol}{orderWeightItem.PricePerUnitAtOrderTime * (decimal)orderWeightItem.Weight:F2}";
        }
    }
}
