using Lababa.Backend.Constants; 
using Lababa.Backend.Models; 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lababa.Backend.Repositories
{
    public class OrderItemItemsRepository
    {
        private readonly string _filePath;
        private readonly char _delimeter = ',';

        public OrderItemItemsRepository()
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileNames.OrderItemItem);
        }

        private List<OrderItemItem> LoadAllEntities()
        {
            var orderItemItems = new List<OrderItemItem>();

            if (!File.Exists(_filePath))
            {
                Console.WriteLine($"File doesn't exist: {_filePath}");
                return orderItemItems;
            }

            try
            {
                var lines = File.ReadAllLines(_filePath);

                foreach (var line in lines)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        var orderItemItem = ParseLine(line);
                        if (orderItemItem != null)
                        {
                            orderItemItems.Add(orderItemItem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading order item items: {ex.Message}");
                throw;
            }

            return orderItemItems;
        }

        private void SaveAllEntities(List<OrderItemItem> orderItemItems)
        {
            try
            {
                var lines = orderItemItems.Select(o => ToCsvLine(o)).ToList();
                File.WriteAllLines(_filePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving order item items: {ex.Message}");
                throw;
            }
        }

        private OrderItemItem ParseLine(string line)
        {
            var parts = line.Split(_delimeter);

            if (parts.Length != 5)
            {
                Console.WriteLine($"Order item item line skipped: {line} - Incorrect number of parts.");
                return null;
            }

            if (!Guid.TryParse(parts[0], out Guid id))
            {
                Console.WriteLine($"Invalid order item item Id in line: {line}");
                return null;
            }

            if (!decimal.TryParse(parts[2], out decimal pricePerPiece))
            {
                Console.WriteLine($"Invalid order item item PricePerPiece in line: {line}");
                return null;
            }

            if (!int.TryParse(parts[3], out int quantity))
            {
                Console.WriteLine($"Invalid order item item Quantity in line: {line}");
                return null;
            }


            if (!Guid.TryParse(parts[4], out Guid orderId))
            {
                Console.WriteLine($"Invalid order item item Order Id in line: {line}");
                return null;
            }

            return new OrderItemItem
            {
                Id = id,
                ItemName = parts[1].Trim(), 
                PricePerPiece = pricePerPiece, 
                Quantity = quantity,        
                OrderId = orderId
            };
        }

        private string ToCsvLine(OrderItemItem orderItemItem)
        {
            return $"{orderItemItem.Id}{_delimeter}" +
                   $"{orderItemItem.ItemName}{_delimeter}" +    
                   $"{orderItemItem.PricePerPiece}{_delimeter}" + 
                   $"{orderItemItem.Quantity}{_delimeter}" +     
                   $"{orderItemItem.OrderId}";
        }

        public List<OrderItemItem> GetAll()
        {
            return LoadAllEntities();
        }

        public OrderItemItem GetById(Guid id)
        {
            var orderItemItems = LoadAllEntities();
            return orderItemItems.FirstOrDefault(o => o.Id == id);
        }

        public void Add(OrderItemItem orderItemItem)
        {
            if (orderItemItem.Id == Guid.Empty)
            {
                orderItemItem.Id = Guid.NewGuid();
            }

            var orderItemItems = LoadAllEntities();
            orderItemItems.Add(orderItemItem);
            SaveAllEntities(orderItemItems);
        }

        public void Update(OrderItemItem orderItemItem)
        {
            var orderItemItems = LoadAllEntities();
            var existingItem = orderItemItems.FirstOrDefault(o => o.Id == orderItemItem.Id);
            if (existingItem != null)
            {
                existingItem.ItemName = orderItemItem.ItemName;     // Update ItemName
                existingItem.Quantity = orderItemItem.Quantity;     // Update Quantity
                existingItem.PricePerPiece = orderItemItem.PricePerPiece; // Update PricePerPiece
                existingItem.OrderId = orderItemItem.OrderId;       // OrderId might also be updated if logic allows
                SaveAllEntities(orderItemItems);
            }
            else
            {
                throw new KeyNotFoundException($"Order item item with Id {orderItemItem.Id} not found for update");
            }
        }

        public void Delete(Guid id)
        {
            var orderItemItems = LoadAllEntities();
            int initialCount = orderItemItems.Count;
            orderItemItems.RemoveAll(o => o.Id == id);
            if (orderItemItems.Count < initialCount)
            {
                SaveAllEntities(orderItemItems);
            }
            else
            {
                throw new KeyNotFoundException($"Order item item with Id {id} not found for deletion");
            }
        }
    }
}