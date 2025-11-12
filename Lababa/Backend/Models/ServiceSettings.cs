using System;

namespace Lababa.Backend.Models
{
    public class WeightService : IEntity
    {
        public Guid Id { get; set; }
        public string ServiceName { get; set; }
        public decimal PricePerUnit { get; set; }
        public double MinWeightPerLoad { get; set; }
    }

    public class ItemService : IEntity
    {
        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public decimal PricePerPiece { get; set; }
    }
}
