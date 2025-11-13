using Lababa.Backend.Constants;
using Lababa.Backend.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Lababa.Backend.Repositories
{
    public class OrderRepository
    {
        private readonly string _filePath;
        private readonly char _delimeter = ',';

        public OrderRepository()
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileNames.Orders);
        }

        private List<Order> LoadAllEntities()
        {
            var orders = new List<Order>();

            if (!File.Exists(_filePath))
            {
                Console.WriteLine($"File doesn't exist: {_filePath}");
                return orders;
            }

            try
            {
                var lines = File.ReadAllLines(_filePath);

                foreach (var line in lines)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        var order = ParseLine(line);
                        if (order != null)
                        {
                            orders.Add(order);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading orderss: {ex.Message}");
                throw;
            }

            return orders;
        }

        private void SaveAllEntities(List<Order> orders)
        {
            try
            {
                var lines = orders.Select(o => ToCsvLine(o)).ToList();
                File.WriteAllLines(_filePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving orders: {ex.Message}");
                throw;
            }
        }

        private Order ParseLine(string line)
        {
            var parts = line.Split(_delimeter);

            if (parts.Length != 8)
            {
                Console.WriteLine($"Order line skipped: {line}");
                return null;
            }

            if (!Guid.TryParse(parts[0], out Guid orderId))
            {
                Console.WriteLine($"Invalid Order's Id in line: {line}");
                return null;
            }


            if (!Enum.TryParse<OrderStatus>(parts[2], out OrderStatus status))
            {
                Console.WriteLine($"Invalid Order's Status in line: {line}");
                return null;
            }


            if (!Enum.TryParse<PaymentStatus>(parts[3], out PaymentStatus paymentStatus))
            {
                Console.WriteLine($"Invalid Order's Payment Status in line: {line}");
                return null;
            }

            if (!DateTime.TryParse(
                parts[4],
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime dateCreated
                ))
            {
                Console.WriteLine($"Invalid Order's Date Created in line: {line}");
                return null;
            }

            if (!DateTime.TryParse(
               parts[5],
               CultureInfo.InvariantCulture,
               DateTimeStyles.None,
               out DateTime dueDate
               ))
            {
                Console.WriteLine($"Invalid Order's Due Date in line: {line}");
                return null;
            }

            if (!Decimal.TryParse(parts[6], out decimal totalAmount))
            {
                Console.WriteLine($"Invalid Order's Total Amount in line: {line}");
                return null;
            }

            if (!Guid.TryParse(parts[7], out Guid customerId))
            {
                Console.WriteLine($"Invalid Order's Customer Id in line: {line}");
                return null;
            }

            return new Order
            {
                Id = orderId,
                OrderNumber = parts[1].Trim(),
                Status = status,
                PaymentStatus = paymentStatus,
                DateCreated = dateCreated,
                DueDate = dueDate,
                TotalAmount = totalAmount,
                CustomerId = customerId
            };
        }

        private string ToCsvLine(Order order)
        {
            return $"{order.Id}{_delimeter}" +
                   $"{order.OrderNumber}{_delimeter}" +
                   $"{order.Status}{_delimeter}" +
                   $"{order.PaymentStatus}{_delimeter}" +
                   $"{order.DateCreated.ToString(CultureInfo.InvariantCulture)}{_delimeter}" +
                   $"{order.DueDate.ToString(CultureInfo.InvariantCulture)}{_delimeter}" +
                   $"{order.TotalAmount}{_delimeter}" +
                   $"{order.CustomerId}";
        }

        public List<Order> GetAll()
        {
            return LoadAllEntities();
        }

        public Order GetById(Guid id)
        {
            var orders = LoadAllEntities();
            return orders.FirstOrDefault(o => o.Id == id);
        }

        public void Add(Order order)
        {
            if (order.Id == Guid.Empty)
            {
                order.Id = Guid.NewGuid();
            }

            if (string.IsNullOrEmpty(order.OrderNumber))
            {
                int totalOrders = this.GetAll().Count;
                order.OrderNumber = $"ORD-{totalOrders + 1:D4}";
            }

            var orders = LoadAllEntities();
            orders.Add(order);
            SaveAllEntities(orders);
        }

        public void Update(Order order)
        {
            var orders = LoadAllEntities();
            var existingOrder = orders.FirstOrDefault(o => o.Id == order.Id);
            if (existingOrder != null)
            {
                existingOrder.Status = order.Status;
                existingOrder.PaymentStatus = order.PaymentStatus;
                existingOrder.DueDate = order.DueDate;
                existingOrder.TotalAmount = order.TotalAmount;
                SaveAllEntities(orders);
            }
            else
            {
                throw new KeyNotFoundException($"Order with Id {order.Id} not found for update");
            }
        }

        public void Delete(Guid id)
        {
            var orders = LoadAllEntities();
            int initialCount = orders.Count;
            orders.RemoveAll(o => o.Id == id);
            if (orders.Count < initialCount)
            {
                SaveAllEntities(orders);
            }
            else
            {
                throw new KeyNotFoundException($"Order with Id {id} not found for deletion");
            }
        }
    }
}
