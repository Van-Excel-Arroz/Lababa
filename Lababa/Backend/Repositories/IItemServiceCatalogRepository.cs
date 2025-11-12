using Lababa.Backend.Models;
using System;
using System.Collections.Generic;

namespace Lababa.Backend.Repositories
{
    public interface IItemServiceCatalogRepository
    {
        List<ItemService> GetAll();
        ItemService GetById(Guid id);
        void Add(ItemService itemService);
        void Update(ItemService itemService);
        void Delete(Guid id);
    }
}
