using Lababa.Backend.Data;
using Lababa.Backend.Models;

namespace Lababa.Backend.Services
{
    public class WeightServiceCatalogService
    {
        private readonly LababaDbContext _context;

        public WeightServiceCatalogService(LababaDbContext context)
        {
            _context = context;
        }

        public void UpdateCatalog(List<WeightService> updatedCatalog)
        {
            var existingServices = _context.WeightServices.ToList();
            var servicesToDelete = updatedCatalog
                .Where(es => !updatedCatalog.Any(us => us.Id == es.Id))
                .ToList();

            if (servicesToDelete.Any())
            {
                _context.WeightServices.RemoveRange(servicesToDelete);
            }

            foreach (var service in updatedCatalog)
            {
                if (service.Id == Guid.Empty)
                {
                    service.Id = Guid.NewGuid();
                    _context.WeightServices.Add(service);
                }
                else
                {
                    _context.WeightServices.Update(service);
                }
            }

            _context.SaveChanges();
        }

        public List<WeightService> GetWeightServiceCatalog()
        {
            return _context.WeightServices.ToList();
        }
    }
}
