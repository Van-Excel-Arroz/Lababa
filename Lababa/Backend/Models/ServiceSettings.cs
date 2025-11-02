namespace Lababa.Backend.Models
{
    public class ShopSettings
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

    public class WeigthServiceCatalogEntry : IEntity
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public decimal PricePerUnit { get; set; }
        public double MinWeightPerLoad { get; set; }
    }

    public class ItemServiceCatalogEntry : IEntity
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public decimal PricePerPiece { get; set; }
    }
}
