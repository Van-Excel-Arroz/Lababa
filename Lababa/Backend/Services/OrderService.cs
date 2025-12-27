using Lababa.Backend.Data;
using Lababa.Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Lababa.Backend.Services
{
    public class OrderService
    {
        private readonly LababaDbContext _context;

        public OrderService(LababaDbContext context)
        {
            _context = context;
        }

        public async Task<Order> GetOrderByIdWithDetails(Guid id)
        {
            return await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.ItemItems)
                .Include(o => o.WeightItems)
                .FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<Order> GetRecentOrder()
        {
            return await _context.Orders.OrderByDescending(o => o.DateCreated).FirstOrDefaultAsync();
        }

        public async Task<List<Order>> GetAllOrdersByCustomerId(Guid customerId)
        {
            return await _context.Orders.Where(o => o.CustomerId == customerId).ToListAsync();
        }

        public async Task<List<Order>> GetOrdersForToday()
        {
            var today = DateTime.Today;

            return await _context.Orders
                .Where(o => o.DateCreated >= today && o.DueDate < today.AddDays(1))
                .ToListAsync();
        }

        public decimal CalculateOrdersTotalAmount(List<Order> orders)
        {
            return orders.Where(o => o.PaymentStatus == PaymentStatus.Paid)
                .Sum(o => o.TotalAmount);
        }

        public async Task CreateOrder(Order order)
        {
            if (order.Id == Guid.Empty)
            {
                order.Id = Guid.NewGuid();
            }

            if (string.IsNullOrEmpty(order.OrderNumber))
            {
                int totalOrders = await _context.Orders.CountAsync();
                order.OrderNumber = $"ORD-{totalOrders + 1:D4}";
            }

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.WeightItems)
                .Include(o => o.ItemItems)
                .ToListAsync();
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

        public List<Order> SearchOrders(string customerTerm, string orderNumber, OrderStatus? status, PaymentStatus? paymentStatus, DateTime fromDate, DateTime toDate)
        {
            IQueryable<Order> query = _context.Orders.Include(o => o.Customer);

            if (!string.IsNullOrWhiteSpace(customerTerm))
            {
                string term = customerTerm.Trim().ToLower();
                query = query.Where(o => o.Customer.FullName.Contains(term) || o.Customer.PhoneNumber.Contains(term));
            }

            if (!string.IsNullOrWhiteSpace(orderNumber))
            {
                string orderNumberSearchTerm = orderNumber.Trim().ToLower();
                query = query.Where(o => o.OrderNumber.ToLower().Contains(orderNumberSearchTerm));
            }

            if (status.HasValue)
                query = query.Where(o => o.Status == status.Value);

            if (paymentStatus.HasValue)
                query = query.Where(o => o.PaymentStatus == paymentStatus.Value);

            DateTime startDate = fromDate.Date;
            DateTime endDate = toDate.Date.AddDays(1).AddSeconds(-1);
            query = query.Where(order => order.DateCreated >= startDate && order.DateCreated <= endDate);

            return query.ToList();
        }
    }
}
