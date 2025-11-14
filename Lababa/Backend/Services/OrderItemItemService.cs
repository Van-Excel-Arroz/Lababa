
using Lababa.Backend.Models;
using Lababa.Backend.Repositories;

namespace Lababa.Backend.Services
{
    public class OrderItemItemService
    {
        private readonly OrderItemItemRepository _repo;

        public OrderItemItemService()
        {
            _repo = new OrderItemItemRepository();
        }

        public void CreateOrderItemItem(OrderItemItem item)
        {
            _repo.Add(item);
        }
    }
}
