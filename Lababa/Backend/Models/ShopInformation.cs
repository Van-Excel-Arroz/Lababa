namespace Lababa.Backend.Models
{
    public class ShopInformation
    {
        public string ShopName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CurrencySymbol { get; set; }
        public WeightUnit DefaultWeightUnit { get; set; }
    }

    public class ReceiptSettings
    {
        public string HeaderMessage { get; set; }
        public string FooterMessage { get; set; }
    }
}
