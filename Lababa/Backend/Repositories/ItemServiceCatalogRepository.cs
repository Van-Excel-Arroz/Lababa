using Lababa.Backend.Constants;
using Lababa.Backend.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lababa.Backend.Repositories
{
    public class ItemServiceCatalogRepository : IItemServiceCatalogRepository
    {
        private readonly string _filePath;
        private readonly char _delimeter = ',';

        public ItemServiceCatalogRepository()
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileNames.ItemServiceCatalog);
        }

        private List<ItemService> LoadAllEntities()
        {
            var itemServiceCatalog = new List<ItemService>();

            if (!File.Exists(_filePath))
            {
                Console.WriteLine($"File doesn't exist: {_filePath}");
                return itemServiceCatalog;
            }

            try
            {
                var lines = File.ReadAllLines(_filePath);

                foreach (var line in lines)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        var itemService = ParseLine(line);
                        if (itemService != null)
                        {
                            itemServiceCatalog.Add(itemService);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading item service catalog: {ex.Message}");
                throw;
            }

            return itemServiceCatalog;
        }

        private void SaveAllEntities(List<ItemService> itemServiceCatalog)
        {
            try
            {
                var lines = itemServiceCatalog.Select(i => ToCsvLine(i)).ToList();
                File.WriteAllLines(_filePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving item service catalog: {ex.Message}");
                throw;
            }
        }

        private ItemService ParseLine(string line)
        {
            var parts = line.Split(_delimeter);

            if (parts.Length != 3)
            {
                Console.WriteLine($"item service line skipped: {line}");
                return null;
            }

            if (!Guid.TryParse(parts[0], out Guid id))
            {
                Console.WriteLine($"Invalid item service Id in line: {line}");
                return null;
            }

            if (!decimal.TryParse(parts[2], out decimal pricePerPiece))
            {
                Console.WriteLine($"Warning: Invalid price per piece in line: {line}");
                return null;
            }

            return new ItemService
            {
                ItemName = parts[1].Trim(),
                PricePerPiece = pricePerPiece,
            };
        }

        private string ToCsvLine(ItemService itemService)
        {
            return $"{itemService.Id}{_delimeter}" +
                   $"{itemService.ItemName}{_delimeter}" +
                   $"{itemService.PricePerPiece}";
        }


        public List<ItemService> GetAll()
        {
            return LoadAllEntities();
        }

        public ItemService GetById(Guid id)
        {
            var itemServiceCatalog = LoadAllEntities();
            return itemServiceCatalog.FirstOrDefault(i => i.Id == id);
        }

        public void Add(ItemService itemService)
        {
            if (itemService.Id == Guid.Empty)
            {
                itemService.Id = Guid.NewGuid();
            }

            var weightServiceCatalog = LoadAllEntities();
            weightServiceCatalog.Add(itemService);
            SaveAllEntities(weightServiceCatalog);
        }

        public void Update(ItemService itemService)
        {
            var itemServiceCatalog = LoadAllEntities();
            var existingItemService = itemServiceCatalog.FirstOrDefault(i => i.Id == itemService.Id);
            if (existingItemService != null)
            {
                existingItemService.ItemName = itemService.ItemName;
                existingItemService.PricePerPiece = itemService.PricePerPiece;
                SaveAllEntities(itemServiceCatalog);
            }
            else
            {
                throw new KeyNotFoundException($"Item service with Id {itemService.Id} not found for update");
            }
        }

        public void Delete(Guid id)
        {
            var itemServiceCatalog = LoadAllEntities();
            int initialCount = itemServiceCatalog.Count;
            itemServiceCatalog.RemoveAll(w => w.Id == id);
            if (itemServiceCatalog.Count < initialCount)
            {
                SaveAllEntities(itemServiceCatalog);
            }
            else
            {
                throw new KeyNotFoundException($"Item service with Id {id} not found for deletion");
            }
        }
    }
}
