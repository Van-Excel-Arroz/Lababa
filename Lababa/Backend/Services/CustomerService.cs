using Lababa.Backend.Models;
using Lababa.Backend.Repositories;
using System;
using System.Collections.Generic;

namespace Lababa.Backend.Services
{
    public class CustomerService
    {
        private readonly CustomerRepository _repo;

        public CustomerService()
        {
            _repo = new CustomerRepository();
        }

        public void AddCustomer(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.FullName))
            {
                throw new ArgumentException("Customer name is required");
            }

            if (string.IsNullOrWhiteSpace(customer.PhoneNumber))
            {
                throw new ArgumentException("Phone number is required");
            }

            customer.DateCreated = DateTime.Now;
            _repo.Add(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return _repo.GetAll();
        }

        public Customer GetCustomerById(Guid id)
        {
            return _repo.GetById(id);
        }

        public void UpdateCustomer(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.FullName))
            {
                throw new ArgumentException("Customer name is required");
            }

            if (string.IsNullOrWhiteSpace(customer.PhoneNumber))
            {
                throw new ArgumentException("Phone number is required");
            }
            _repo.Update(customer);
        }

        public void DeleteCustomer(Guid id)
        {
            _repo.Delete(id);
        }
    }
}