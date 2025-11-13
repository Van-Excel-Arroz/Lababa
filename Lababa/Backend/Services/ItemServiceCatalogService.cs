using Lababa.Backend.Models;
using Lababa.Backend.Repositories;
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

        public void SaveCatalog(List<ItemService> itemServiceCatalog)
        {
            _repo.SaveAll(itemServiceCatalog);
        }

        public List<ItemService> GetItemServiceCatalog()
        {
            return _repo.GetAll();
        }
    }
}
