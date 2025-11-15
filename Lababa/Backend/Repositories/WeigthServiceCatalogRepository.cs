using Lababa.Backend.Constants;
using Lababa.Backend.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lababa.Backend.Repositories
{
    public class WeigthServiceCatalogRepository
    {
        private readonly string _filePath;
        private readonly char _delimeter = ',';

        public WeigthServiceCatalogRepository()
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileNames.WeightServiceCatalog);
        }

        private List<WeightService> LoadAllEntities()
        {
            var weightServiceCatalog = new List<WeightService>();

            if (!File.Exists(_filePath))
            {
                Console.WriteLine($"File doesn't exist: {_filePath}");
                return weightServiceCatalog;
            }

            try
            {
                var lines = File.ReadAllLines(_filePath);

                foreach (var line in lines)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        var weightService = ParseLine(line);
                        if (weightService != null)
                        {
                            weightServiceCatalog.Add(weightService);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading weight service catalog: {ex.Message}");
                throw;
            }

            return weightServiceCatalog;
        }

        private void SaveAllEntities(List<WeightService> weightServiceCatalog)
        {
            try
            {
                var lines = weightServiceCatalog.Select(w => ToCsvLine(w)).ToList();
                File.WriteAllLines(_filePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving weight service catalog: {ex.Message}");
                throw;
            }
        }

        private WeightService ParseLine(string line)
        {
            var parts = line.Split(_delimeter);

            if (parts.Length != 4)
            {
                Console.WriteLine($"weight service line skipped: {line}");
                return null;
            }

            if (!Guid.TryParse(parts[0], out Guid id))
            {
                Console.WriteLine($"Invalid weight service Id in line: {line}");
                return null;
            }

            if (!decimal.TryParse(parts[2], out decimal pricePerUnit))
            {
                Console.WriteLine($"Warning: Invalid price per unit in line: {line}");
                return null;
            }

            if (!double.TryParse(parts[3], out double minWeightPerLoad))
            {
                Console.WriteLine($"Warning: Invalid min weight per load in line: {line}");
                return null;
            }

            return new WeightService
            {
                Id = id,
                ServiceName = parts[1].Trim(),
                PricePerUnit = pricePerUnit,
                MinWeightPerLoad = minWeightPerLoad
            };
        }

        private string ToCsvLine(WeightService weightService)
        {
            return $"{weightService.Id}{_delimeter}" +
                   $"{weightService.ServiceName}{_delimeter}" +
                   $"{weightService.PricePerUnit}{_delimeter}" +
                   $"{weightService.MinWeightPerLoad}";
        }

        public List<WeightService> GetAll()
        {
            return LoadAllEntities();
        }

        public void SaveAll(List<WeightService> weightServices)
        {
            var weightServicesWithIds = weightServices.Select(ws =>
            {
                if (ws.Id == Guid.Empty) 
                {
                    ws.Id = Guid.NewGuid();
                }
                return ws;
            });
            SaveAllEntities(weightServicesWithIds.ToList());
        }

        public WeightService GetById(Guid id)
        {
            var weightServiceCatalog = LoadAllEntities();
            return weightServiceCatalog.FirstOrDefault(w => w.Id == id);
        }

        public void Add(WeightService weightService)
        {
            if (weightService.Id == Guid.Empty)
            {
                weightService.Id = Guid.NewGuid();
            }

            var weightServiceCatalog = LoadAllEntities();
            weightServiceCatalog.Add(weightService);
            SaveAllEntities(weightServiceCatalog);
        }

        public void Update(WeightService weightService)
        {
            var weightServiceCatalog = LoadAllEntities();
            var existingWeightService = weightServiceCatalog.FirstOrDefault(w => w.Id == weightService.Id);
            if (existingWeightService != null)
            {
                existingWeightService.ServiceName = weightService.ServiceName;
                existingWeightService.PricePerUnit = weightService.PricePerUnit;
                existingWeightService.MinWeightPerLoad = weightService.MinWeightPerLoad;
                SaveAllEntities(weightServiceCatalog);
            }
            else
            {
                throw new KeyNotFoundException($"Weight service with Id {weightService.Id} not found for update");
            }
        }

        public void Delete(Guid id)
        {
            var weightServiceCatalog = LoadAllEntities();
            int initialCount = weightServiceCatalog.Count;
            weightServiceCatalog.RemoveAll(w => w.Id == id);
            if (weightServiceCatalog.Count < initialCount)
            {
                SaveAllEntities(weightServiceCatalog);
            }
            else
            {
                throw new KeyNotFoundException($"Weight service with Id {id} not found for deletion");
            }
        }
    }
}
