using Lababa.Backend.Models;
using System;
using System.Collections.Generic;

namespace Lababa.Backend.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();
        Customer GetById(Guid Id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Guid id);
    }
}
