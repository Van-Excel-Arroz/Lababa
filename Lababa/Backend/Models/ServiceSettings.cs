using System;

namespace Lababa.Backend.Models
{
    public class WeigthServiceCatalogEntry : IEntity
    {
        public Guid Id { get; set; }
        public string ServiceName { get; set; }
        public decimal PricePerUnit { get; set; }
        public double MinWeightPerLoad { get; set; }
    }

    public class ItemServiceCatalogEntry : IEntity
    {
        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public decimal PricePerPiece { get; set; }
    }
}
