using System;
using System.Collections.Generic;

namespace Lababa.Backend.Models
{
    public class Order : IEntity
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public OrderStatus Status { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public Guid CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItemItem> ItemItems { get; set; }
        public virtual ICollection<OrderWeightItem> WeightItems { get; set; }
    }
}
