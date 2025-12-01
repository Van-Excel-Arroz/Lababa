using Lababa.Backend.Data;
using Lababa.Backend.Models;

namespace Lababa.Backend.Services
{
    public class ItemServiceCatalogService
    {
        private readonly LababaDbContext _context;
        public ItemServiceCatalogService(LababaDbContext context)
        {
            _context = context;
        }

        public void UpdateCatalog(List<ItemService> itemServiceCatalog)
        {
            var existingServices = _context.ItemServices.ToList();
            var servicesToDelete = existingServices
                .Where(es => !itemServiceCatalog.Any(us => us.Id == es.Id))
                .ToList();

            if (servicesToDelete.Any())
            {
                _context.ItemServices.RemoveRange(servicesToDelete);
            }

            foreach (var service in itemServiceCatalog)
            {
                if (service.Id == Guid.Empty)
                {
                    service.Id = Guid.NewGuid();
                    _context.ItemServices.Add(service);
                }
                else
                {
                    _context.ItemServices.Update(service);
                }
            }

            _context.SaveChanges();
        }

        public List<ItemService> GetAll()
        {
            return _context.ItemServices.ToList();
        }
    }
}
