using Lababa.Backend.Models;
using Lababa.Backend.Repositories;
using System;
using System.Collections.Generic;

namespace Lababa.Backend.Services
{
    public class CustomerService
    {
        private static CustomerService _instance;
        private static readonly object _lock = new object();
        private readonly ICustomerRepository _customerRepository;

        private CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public static CustomerService Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new CustomerService();
                        }
                    }
                }
                return _instance;
            }
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