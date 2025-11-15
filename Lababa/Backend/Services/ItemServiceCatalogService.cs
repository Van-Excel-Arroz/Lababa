using Lababa.Backend.Models;
using Lababa.Backend.Repositories;
using System;
using System.Collections.Generic;

namespace Lababa.Backend.Services
{
    public class ItemServiceCatalogService
    {
        private readonly ItemServiceCatalogRepository _repo;
        public ItemServiceCatalogService()
        {
            _repo = new ItemServiceCatalogRepository();
        }

        public void SaveItemServiceCatalog(List<ItemService> itemServiceCatalog)
        {
            _repo.SaveAll(itemServiceCatalog);
        }

        public void CreateItemServiceCatalog(List<ItemService> itemServiceCatalog)
        {
            foreach (var itemService in itemServiceCatalog)
            {
                _repo.Add(itemService);
            }
        }

        public void DeleteItemService(Guid id)
        {
            _repo.Delete(id);
        }

        public List<ItemService> GetItemServiceCatalog()
        {
            return _repo.GetAll();
        }
    }
}
