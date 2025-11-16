using Lababa.Backend.Constants; 
using Lababa.Backend.Models; 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lababa.Backend.Repositories
{
    public class OrderItemItemRepository
    {
        private readonly string _filePath;
        private readonly char _delimeter = ',';

        public OrderItemItemRepository()
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

            if (parts.Length != 6)
            {
                Console.WriteLine($"Order item item line skipped: {line} - Incorrect number of parts.");
                return null;
            }


            if (!Guid.TryParse(parts[0], out Guid id))
            {
                Console.WriteLine($"Invalid order item item Id in line: {line}");
                return null;
            }

            if (!Guid.TryParse(parts[1], out Guid serviceId))
            {
                Console.WriteLine($"Invalid order item item ServiceId in line: {line}");
                return null;
            }

            if (!decimal.TryParse(parts[3], out decimal pricePerPiece))
            {
                Console.WriteLine($"Invalid order item item PricePerPiece in line: {line}");
                return null;
            }

            if (!int.TryParse(parts[4], out int quantity))
            {
                Console.WriteLine($"Invalid order item item Quantity in line: {line}");
                return null;
            }


            if (!Guid.TryParse(parts[5], out Guid orderId))
            {
                Console.WriteLine($"Invalid order item item Order Id in line: {line}");
                return null;
            }

            return new OrderItemItem
            {
                Id = id,
                ServiceId = serviceId,
                ItemNameAtOrderTime = parts[1].Trim(), 
                PricePerPieceAtOrderTime = pricePerPiece, 
                Quantity = quantity,        
                OrderId = orderId
            };
        }

        private string ToCsvLine(OrderItemItem orderItemItem)
        {
            return $"{orderItemItem.Id}{_delimeter}" +
                   $"{orderItemItem.ServiceId}{_delimeter}" +
                   $"{orderItemItem.ItemNameAtOrderTime}{_delimeter}" +    
                   $"{orderItemItem.PricePerPieceAtOrderTime}{_delimeter}" + 
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
            return orderItemItems.FirstOrDefault(o => o.ServiceId == id);
        }

        public void Add(OrderItemItem orderItemItem)
        {
            if (orderItemItem.Id == Guid.Empty)
            {
                orderItemItem.Id = Guid.NewGuid();
            }

            if (orderItemItem.ServiceId == Guid.Empty)
            {
                throw new KeyNotFoundException($"Order item no id {orderItemItem.ItemNameAtOrderTime} for adding");
            }

            var orderItemItems = LoadAllEntities();
            orderItemItems.Add(orderItemItem);
            SaveAllEntities(orderItemItems);
        }

        public void Update(OrderItemItem orderItemItem)
        {
            var orderItemItems = LoadAllEntities();
            var existingItem = orderItemItems.FirstOrDefault(o => o.ServiceId == orderItemItem.ServiceId);
            if (existingItem != null)
            {
                existingItem.ItemNameAtOrderTime = orderItemItem.ItemNameAtOrderTime;     
                existingItem.Quantity = orderItemItem.Quantity;     
                existingItem.PricePerPieceAtOrderTime = orderItemItem.PricePerPieceAtOrderTime; 
                existingItem.OrderId = orderItemItem.OrderId;       
                SaveAllEntities(orderItemItems);
            }
            else
            {
                throw new KeyNotFoundException($"Order item item with Id {orderItemItem.ServiceId} not found for update");
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