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

        private List<WeigthServiceCatalogEntry> LoadAllEntities()
        {
            var weightServiceCatalog = new List<WeigthServiceCatalogEntry>();

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
                        var weightServiceCatalogEntry = ParseLine(line);
                        if (weightServiceCatalogEntry != null)
                        {
                            weightServiceCatalog.Add(weightServiceCatalogEntry);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading weight service catalog entry: {ex.Message}");
                throw;
            }

            return weightServiceCatalog;
        }

        private void SaveAllEntities(List<WeigthServiceCatalogEntry> weightServiceCatalog)
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

        private WeigthServiceCatalogEntry ParseLine(string line)
        {
            var parts = line.Split(_delimeter);

            if (parts.Length != 3)
            {
                Console.WriteLine($"weight service catalog entry line skipped: {line}");
                return null;
            }

            if (!Guid.TryParse(parts[0], out Guid id))
            {
                Console.WriteLine($"Invalid weight service catalog entry Id in line: {line}");
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

            return new WeigthServiceCatalogEntry
            {
                ServiceName = parts[1].Trim(),
                PricePerUnit = pricePerUnit,
                MinWeightPerLoad = minWeightPerLoad
            };
        }

        private string ToCsvLine(WeigthServiceCatalogEntry weigthServiceCatalogEntry)
        {
            return $"{weigthServiceCatalogEntry.Id}{_delimeter}" +
                   $"{weigthServiceCatalogEntry.ServiceName}{_delimeter}" +
                   $"{weigthServiceCatalogEntry.PricePerUnit}{_delimeter}" +
                   $"{weigthServiceCatalogEntry.MinWeightPerLoad}";
        }
    }
}
