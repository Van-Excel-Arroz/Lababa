using Lababa.Backend.Models;
using Lababa.Backend.Repositories;
using System;
using System.Collections.Generic;

namespace Lababa.Backend.Services
{
    public class OrderService
    {
        private readonly OrderRepository _repo;

        public OrderService()
        {
            _repo = new OrderRepository();
        }

        public void CreateOrder(Order order)
        {
            _repo.Add(order);
        }

        public List<Order> GetAllOrders()
        {
            return _repo.GetAll();
        }

        public void UpdateOrder(Order order)
        {
            _repo.Update(order);
        }

        public void DeleteOrder(Guid id)
        {
            _repo.Delete(id);
        }
    }
}
