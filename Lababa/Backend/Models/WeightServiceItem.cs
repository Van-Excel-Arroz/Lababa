namespace Lababa.Backend.Models
{
    public class WeightServiceItem : IEntity
    {
        public int Id { get; set; }
        public string WashType { get; set; }
        public decimal PricePerUnit { get; set; }
        public double Weight { get; set; }
        public int OrderId { get; set; }
    }
}
