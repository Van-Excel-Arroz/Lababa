using Lababa.Backend.Models;
using Lababa.Backend.Repositories;
using System;
using System.Collections.Generic;

namespace Lababa.Backend.Services
{
    public class CustomerService
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
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
            _customerRepository.Add(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetCustomerById(Guid id)
        {
            return _customerRepository.GetById(id);
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
            _customerRepository.Update(customer);
        }

        public void DeleteCustomer(Guid id)
        {
            _customerRepository.Delete(id);
        }
    }
}