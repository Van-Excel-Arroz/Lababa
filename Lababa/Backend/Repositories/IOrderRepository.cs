using Lababa.Backend.Models;
using System;
using System.Collections.Generic;

namespace Lababa.Backend.Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
        Order GetById(Guid Id);
        void Add(Order order);
        void Update(Order order);
        void Delete(Guid id);
    }
}
