using Lababa.Backend.Models;
using Lababa.Backend.Repositories;
using System;
using System.Collections.Generic;

namespace Lababa.Backend.Services
{
    public class OrderService
    {
        private readonly OrderRepository _repo;

        public OrderService()
        {
            _repo = new OrderRepository();
        }

        public Order GetRecentOrder()
        {
            var allOrders = _repo.GetAll();
            if (allOrders.Count > 0)
            {
            return allOrders[allOrders.Count - 1];

            } else
            {
                return null;
            }
        }

        public List<Order> GetOrdersForToday()
        {
            var allOrders = _repo.GetAll();
            var today = DateTime.Today;
            return allOrders.FindAll(o => o.DateCreated.Date == today || o.DueDate.Date >= today);
        }

        public decimal CalculateOrdersTotalAmount(List<Order> orders) 
        {
            decimal total = 0;
            foreach (var order in orders)
            {
                if (order.PaymentStatus == PaymentStatus.Paid)
                {
                    total += order.TotalAmount;
                }
            }

            return total;
        }


        public void CreateOrder(Order order)
        {
            _repo.Add(order);
        }

        public List<Order> GetAllOrders()
        {
            return _repo.GetAll();
        }

        public void UpdateOrder(Order order)
        {
            _repo.Update(order);
        }

        public void DeleteOrder(Guid id)
        {
            _repo.Delete(id);
        }
    }
}
