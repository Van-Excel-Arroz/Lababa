namespace Lababa.Backend.Models
{

    public class ShopInformationData
    {
        public string ShopName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }

    public class PricingMethodData
    {
        public PricingMethod PricingMethod { get; set; }
        public WeightUnit WeightUnit { get; set; }
        public string CurrencySymbol { get; set; }
    }
}
