using System;

namespace Lababa.Backend.Models
{
    public class OrderItemItem : IEntity
    {
        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerPiece { get; set; }
        public Guid OrderId { get; set; }
    }
    public class OrderWeightItem : IEntity
    {
        public Guid Id { get; set; }
        public string ServiceName { get; set; }
        public decimal PricePerUnit { get; set; }
        public double Weight { get; set; }
        public Guid OrderId { get; set; }
    }
}
