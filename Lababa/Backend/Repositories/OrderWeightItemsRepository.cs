
using Lababa.Backend.Constants;
using Lababa.Backend.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lababa.Backend.Repositories
{
    public class OrderWeightItemsRepository
    {
        private readonly string _filePath;
        private readonly char _delimeter = ',';

        public OrderWeightItemsRepository()
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

            if (parts.Length != 4)
            {
                Console.WriteLine($"Order weight item line skipped: {line}");
                return null;
            }

            if (!Guid.TryParse(parts[0], out Guid id))
            {
                Console.WriteLine($"Invalid order weight item Id in line: {line}");  
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
                Id = id,
                ServiceName= parts[1].Trim(),
                PricePerUnit = pricePerUnit,
                Weight = weight,
                OrderId = orderId
            };
        }

        private string ToCsvLine(OrderWeightItem orderWeightItem)
        {
            return $"{orderWeightItem.Id}{_delimeter}" +
                   $"{orderWeightItem.ServiceName}{_delimeter}" +
                   $"{orderWeightItem.PricePerUnit}{_delimeter}" +
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
            return orderWeightItems.FirstOrDefault(o => o.Id == id);
        }

        public void Add(OrderWeightItem orderWeightItem)
        {
            if (orderWeightItem.Id == Guid.Empty)
            {
                orderWeightItem.Id = Guid.NewGuid();
            }

            var orderWeightItems = LoadAllEntities();
            orderWeightItems.Add(orderWeightItem);
            SaveAllEntities(orderWeightItems);
        }

        public void Update(OrderWeightItem orderWeightItem)
        {
            var orderWeightItems = LoadAllEntities();
            var existingItem = orderWeightItems.FirstOrDefault(o => o.Id == orderWeightItem.Id);
            if (existingItem != null)
            {
                existingItem.ServiceName = orderWeightItem.ServiceName;
                existingItem.PricePerUnit = orderWeightItem.PricePerUnit;
                existingItem.Weight = orderWeightItem.Weight;
                SaveAllEntities(orderWeightItems);
            }
            else
            {
                throw new KeyNotFoundException($"Order weight item with Id {orderWeightItem.Id} not found for update");
            }
        }

        public void Delete(Guid id)
        {
            var orderWeightItems = LoadAllEntities();
            int initialCount = orderWeightItems.Count;
            orderWeightItems.RemoveAll(o => o.Id == id);
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
