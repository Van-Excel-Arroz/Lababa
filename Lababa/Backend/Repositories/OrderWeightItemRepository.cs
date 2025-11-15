
using Lababa.Backend.Constants;
using Lababa.Backend.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lababa.Backend.Repositories
{
    public class OrderWeightItemRepository
    {
        private readonly string _filePath;
        private readonly char _delimeter = ',';

        public OrderWeightItemRepository()
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileNames.OrderWeightItem);
        }

        private List<OrderWeightItem> LoadAllEntities()
        {
            var orderWeightItems = new List<OrderWeightItem>();

            if (!File.Exists(_filePath))
            {
                Console.WriteLine($"File doesn't exist: {_filePath}");
                return orderWeightItems;
            }

            try
            {
                var lines = File.ReadAllLines(_filePath);

                foreach (var line in lines)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        var orderWeightItem = ParseLine(line);
                        if (orderWeightItem != null)
                        {
                            orderWeightItems.Add(orderWeightItem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading order weight items: {ex.Message}");
                throw;
            }

            return orderWeightItems;
        }

        private void SaveAllEntities(List<OrderWeightItem> orderWeightItems)
        {
            try
            {
                var lines = orderWeightItems.Select(o => ToCsvLine(o)).ToList();
                File.WriteAllLines(_filePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving order weight items: {ex.Message}");
                throw;
            }
        }

        private OrderWeightItem ParseLine(string line)
        {
            var parts = line.Split(_delimeter);

            if (parts.Length != 5)
            {
                Console.WriteLine($"Order weight item line skipped: {line}");
                return null;
            }

            if (!Guid.TryParse(parts[0], out Guid serviceId))
            {
                Console.WriteLine($"Invalid order weight item ServiceId in line: {line}");  
                return null;
            }

            if (!decimal.TryParse(parts[2], out decimal pricePerUnit))
            {
                Console.WriteLine($"Invalid order weight item PricePerUnit in line: {line}");
                return null;
            }
                
            if (!double.TryParse(parts[3], out double weight))
            {
                Console.WriteLine($"Invalid order weight item Weight in line: {line}");
                return null;
            }

            if (!Guid.TryParse(parts[4], out Guid orderId))
            {
                Console.WriteLine($"Invalid order weight item Order Id in line: {line}");
                return null;
            }


            return new OrderWeightItem
            {
                ServiceId = serviceId,
                ServiceNameAtOrderTime= parts[1].Trim(),
                PricePerUnitAtOrderTime = pricePerUnit,
                Weight = weight,
                OrderId = orderId
            };
        }

        private string ToCsvLine(OrderWeightItem orderWeightItem)
        {
            return $"{orderWeightItem.ServiceId}{_delimeter}" +
                   $"{orderWeightItem.ServiceNameAtOrderTime}{_delimeter}" +
                   $"{orderWeightItem.PricePerUnitAtOrderTime}{_delimeter}" +
                   $"{orderWeightItem.Weight}{_delimeter}" +
                   $"{orderWeightItem.OrderId}";
        }

        public List<OrderWeightItem> GetAll()
        {
            return LoadAllEntities();
        }

        public OrderWeightItem GetById(Guid id)
        {
            var orderWeightItems = LoadAllEntities();
            return orderWeightItems.FirstOrDefault(o => o.ServiceId == id);
        }

        public void Add(OrderWeightItem orderWeightItem)
        {
            if (orderWeightItem.ServiceId == Guid.Empty)
            {
                throw new KeyNotFoundException($"Order weight item no id {orderWeightItem.ServiceNameAtOrderTime} for adding: service id {orderWeightItem.ServiceId}");

            }

            var orderWeightItems = LoadAllEntities();
            orderWeightItems.Add(orderWeightItem);
            SaveAllEntities(orderWeightItems);
        }

        public void Update(OrderWeightItem orderWeightItem)
        {
            var orderWeightItems = LoadAllEntities();
            var existingItem = orderWeightItems.FirstOrDefault(o => o.ServiceId == orderWeightItem.ServiceId);
            if (existingItem != null)
            {
                existingItem.ServiceNameAtOrderTime = orderWeightItem.ServiceNameAtOrderTime;
                existingItem.PricePerUnitAtOrderTime = orderWeightItem.PricePerUnitAtOrderTime;
                existingItem.Weight = orderWeightItem.Weight;
                SaveAllEntities(orderWeightItems);
            }
            else
            {
                throw new KeyNotFoundException($"Order weight item with Id {orderWeightItem.ServiceId} not found for update");
            }
        }

        public void Delete(Guid id)
        {
            var orderWeightItems = LoadAllEntities();
            int initialCount = orderWeightItems.Count;
            orderWeightItems.RemoveAll(o => o.ServiceId == id);
            if (orderWeightItems.Count < initialCount)
            {
                SaveAllEntities(orderWeightItems);
            }
            else
            {
                throw new KeyNotFoundException($"Order weight item with Id {id} not found for deletion");
            }
        }
    }
}
