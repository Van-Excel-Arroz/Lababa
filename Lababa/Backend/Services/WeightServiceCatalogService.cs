using Lababa.Backend.Models;
using Lababa.Backend.Repositories;
using System.Collections.Generic;

namespace Lababa.Backend.Services
{
    class WeightServiceCatalogService
    {
        private readonly WeigthServiceCatalogRepository _repo;

        public WeightServiceCatalogService()
        {
            _repo = new WeigthServiceCatalogRepository();
        }

        public void SaveCatalog(List<WeightService> weightServiceCatalog)
        {
            _repo.SaveAll(weightServiceCatalog);
        }

        public List<WeightService> GetWeightServiceCatalog()
        {
            return _repo.GetAll();
        }
    }
}
