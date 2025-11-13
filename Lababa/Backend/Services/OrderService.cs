using Lababa.Backend.Models;
using Lababa.Backend.Repositories;

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
    }
}
