using System;

namespace Lababa.Backend.Models
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public OrderStatus Status { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsPriorityService { get; set; }
        public bool IsExpressService { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Surcharge { get; set; }
        public decimal Total { get; set; }
        public int CustomerId { get; set; } = 0;
    }
}
