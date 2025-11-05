using System;

namespace Lababa.Backend.Models
{
    public class OrderItemProduct : IEntity
    {
        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
        public Guid OrderId { get; set; }
    }
    public class OrderWeightProduct : IEntity
    {
        public Guid Id { get; set; }
        public string ServiceName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
        public double Weight { get; set; }
        public Guid OrderId { get; set; }
    }
}
