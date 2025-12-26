using Lababa.Backend.Data;
using Lababa.Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Lababa.Backend.Services
{
    public class CustomerService
    {
        private readonly LababaDbContext _context;

        public CustomerService(LababaDbContext context)
        {
            _context = context;
        }

        public async Task AddCustomer(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.FullName))
                throw new ArgumentException("Customer name is required");

            if (string.IsNullOrWhiteSpace(customer.PhoneNumber))
                throw new ArgumentException("Phone number is required");

            customer.DateCreated = DateTime.Now;
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomerById(Guid id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public void UpdateCustomer(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.FullName))
                throw new ArgumentException("Customer name is required");

            if (string.IsNullOrWhiteSpace(customer.PhoneNumber))
                throw new ArgumentException("Phone number is required");

            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public void DeleteCustomer(Guid id)
        {
            var customer = _context.Customers.Find(id);

            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }
    }
}