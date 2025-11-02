namespace Lababa.Backend.Models
{
    public class ItemServiceItem : IEntity
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
        public int OrderId { get; set; }
    }
    public class WeightServiceItem : IEntity
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
        public double Weight { get; set; }
        public int OrderId { get; set; }
    }
}
