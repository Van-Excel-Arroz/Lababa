using System;

namespace Lababa.Backend.Models
{
    public class OrderItemItem
    {
        public Guid ServiceId { get; set; }
        public string ItemNameAtOrderTime { get; set; }
        public decimal PricePerPieceAtOrderTime { get; set; }
        public int Quantity { get; set; }
        public Guid OrderId { get; set; }
    }
    public class OrderWeightItem 
    {
        public Guid ServiceId { get; set; }
        public string ServiceNameAtOrderTime { get; set; }
        public decimal PricePerUnitAtOrderTime { get; set; }
        public double Weight { get; set; }
        public Guid OrderId { get; set; }
    }
}
