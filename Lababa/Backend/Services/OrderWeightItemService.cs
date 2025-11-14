
using Lababa.Backend.Models;
using Lababa.Backend.Repositories;

namespace Lababa.Backend.Services
{
    public class OrderWeightItemService
    {
        private readonly OrderWeightItemRepository _repo;

        public OrderWeightItemService()
        {
            _repo = new OrderWeightItemRepository();
        }

        public void CreateOrderWeightItem(OrderWeightItem item)
        {
            _repo.Add(item);
        }
    }
}
