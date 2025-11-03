using System;

namespace Lababa.Backend.Models
{
    public class Order : IEntity
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public OrderStatus Status { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public Guid CustomerId { get; set; }
    }
}
