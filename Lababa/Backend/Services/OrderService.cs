using Lababa.Backend.Data;
using Lababa.Backend.Models;
using Lababa.Backend.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lababa.Backend.Services
{
    public class OrderService
    {
        private readonly LababaDbContext _context;

        public OrderService(LababaDbContext context)
        {
            _context = context;
        }

        public Order GetRecentOrder()
        {
            return _context.Orders.OrderByDescending(o => o.DateCreated).FirstOrDefault();
        }

        public List<Order> GetAllOrdersByCustomerId(Guid customerId)
        {
            return _context.Orders.Where(o => o.CustomerId == customerId).ToList();
        }

        public List<Order> GetOrdersForToday()
        {
            var today = DateTime.Today;

            return _context.Orders
                .Where(o => o.DateCreated == today || o.DueDate >= today)
                .ToList();
        }

        public decimal CalculateOrdersTotalAmount(List<Order> orders) 
        {
            return orders.Where(o => o.PaymentStatus == PaymentStatus.Paid)
                .Sum(o => o.TotalAmount);
        }

        public void CreateOrder(Order order)
        {
            if (order.Id == Guid.Empty)
            {
                order.Id = Guid.NewGuid();
            }

            if (string.IsNullOrEmpty(order.OrderNumber))
            {
                int totalOrders = _context.Orders.Count();
                order.OrderNumber = $"ORD-{totalOrders + 1:D4}";
            }

            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public List<Order> GetAllOrders()
        {
            return _context.Orders.Include(o => o.Customer).ToList(); 
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void DeleteOrder(Guid id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }
    }
}
