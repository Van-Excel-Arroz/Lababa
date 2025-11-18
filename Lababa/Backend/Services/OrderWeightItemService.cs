
using Lababa.Backend.Models;
using Lababa.Backend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lababa.Backend.Services
{
    public class OrderWeightItemService
    {
        private readonly OrderWeightItemRepository _repo;
        private readonly List<WeightService> _catalog;

        public OrderWeightItemService()
        {
            _repo = new OrderWeightItemRepository();
            _catalog = new WeightServiceCatalogService().GetWeightServiceCatalog();
        }

        public void DeleteOrderWeightItem(Guid id)
        {
            _repo.Delete(id);
        }
        public List<OrderWeightItem> GetAllOrderWeightItems(Guid orderId)
        {
            return _repo.GetAll().Where(owi => owi.OrderId == orderId).ToList();
        }

        public void CreateOrderWeightItem(OrderWeightItem item)
        {
            if (_catalog.Any(s => s.Id == item.ServiceId))
            {
                _repo.Add(item);
            }
            else
            {
                throw new KeyNotFoundException($"Order weight item with {item.ServiceId} does not exist on weight service catalog!");
            }
        }
    }
}
