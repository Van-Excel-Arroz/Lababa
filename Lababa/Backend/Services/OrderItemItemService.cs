
using Lababa.Backend.Models;
using Lababa.Backend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lababa.Backend.Services
{
    public class OrderItemItemService
    {
        private readonly OrderItemItemRepository _repo;
        private readonly List<ItemService> _catalog;

        public OrderItemItemService()
        {
            _repo = new OrderItemItemRepository();
            _catalog = new ItemServiceCatalogRepository().GetAll();
        }

        public void CreateOrderItemItem(OrderItemItem item)
        {
            if (_catalog.Any(s => Guid.Equals(s.Id, item.ServiceId)))
            {
                _repo.Add(item);
            }
            else
            {
                throw new KeyNotFoundException($"Order item item with {item.ServiceId} does not exist on Item service catalog!");
            }
        }
    }
}
