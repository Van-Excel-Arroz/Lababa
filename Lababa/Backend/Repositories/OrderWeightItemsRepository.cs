
using Lababa.Backend.Constants;
using Lababa.Backend.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

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
            var items = new List<OrderWeightItem>();

            if (!File.Exists(_filePath))
            {
                Console.WriteLine($"File doesn't exist: {_filePath}");
                return items;
            }

            try
            {
                var lines = File.ReadAllLines(_filePath);

                foreach (var line in lines)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        var customer = ParseLine(line);
                        if (customer != null)
                        {
                            items.Add(customer);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading customers: {ex.Message}");
                throw;
            }

            return items;
        }

        private void SaveAllEntities(List<Customer> customers)
        {
            try
            {
                var lines = customers.Select(c => ToCsvLine(c)).ToList();
                File.WriteAllLines(_filePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving customers: {ex.Message}");
                throw;
            }
        }

        private Customer ParseLine(string line)
        {
            var parts = line.Split(_delimeter);

            if (parts.Length != 5)
            {
                Console.WriteLine($"Customer line skipped: {line}");
                return null;
            }

            if (!Guid.TryParse(parts[0], out Guid id))
            {
                Console.WriteLine($"Invalid Customer Id in line: {line}");
                return null;
            }

            if (!DateTime.TryParse(
                parts[4],
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime dateCreated
                ))
            {
                Console.WriteLine($"Warning: Invalid DateCreated in line: {line}");
                return null;
            }

            return new Customer
            {
                Id = id,
                FullName = parts[1].Trim(),
                PhoneNumber = parts[2].Trim(),
                Address = parts[3].Trim(),
                DateCreated = dateCreated
            };
        }

        private string ToCsvLine(Customer customer)
        {
            return $"{customer.Id}{_delimeter}" +
                   $"{customer.FullName}{_delimeter}" +
                   $"{customer.PhoneNumber}{_delimeter}" +
                   $"{customer.Address}{_delimeter}" +
                   $"{customer.DateCreated.ToString(CultureInfo.InvariantCulture)}";
        }

        public List<Customer> GetAll()
        {
            return LoadAllEntities();
        }

        public Customer GetById(Guid id)
        {
            var customers = LoadAllEntities();
            return customers.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Customer customer)
        {
            if (customer.Id == Guid.Empty)
            {
                customer.Id = Guid.NewGuid();
            }

            var customers = LoadAllEntities();
            customers.Add(customer);
            SaveAllEntities(customers);
        }

        public void Update(Customer customer)
        {
            var customers = LoadAllEntities();
            var existingCustomer = customers.FirstOrDefault(c => c.Id == customer.Id);
            if (existingCustomer != null)
            {
                existingCustomer.FullName = customer.FullName;
                existingCustomer.PhoneNumber = customer.PhoneNumber;
                existingCustomer.Address = customer.Address;
                SaveAllEntities(customers);
            }
            else
            {
                throw new KeyNotFoundException($"Customer with Id {customer.Id} not found for update");
            }
        }

        public void Delete(Guid id)
        {
            var customers = LoadAllEntities();
            int initialCount = customers.Count;
            customers.RemoveAll(c => c.Id == id);
            if (customers.Count < initialCount)
            {
                SaveAllEntities(customers);
            }
            else
            {
                throw new KeyNotFoundException($"Customer with Id {id} not found for deletion");
            }
        }
    }
}
