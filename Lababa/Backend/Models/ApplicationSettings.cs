using System;

namespace Lababa.Backend.Models
{
    public class ApplicationSettings
    {
        public int Id { get; set; }
        public string ShopName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ReceiptMessage { get; set; }
        public WeightUnit DefaultWeightUnit { get; set; }
        public string CurrencySymbol { get; set; }
    }
}
