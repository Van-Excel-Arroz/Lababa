using Lababa.Backend.Models;
using Lababa.Backend.Repositories;
using System;
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

        public void SaveWeightServiceCatalog(List<WeightService> weightServiceCatalog)
        {
            _repo.SaveAll(weightServiceCatalog);
        }

        public void CreateServiceWeightCatalog(List<WeightService> weightServiceCatalog)
        {
            foreach (var weightService in weightServiceCatalog)
            {
                _repo.Add(weightService);
            }
        }

        public void DeleteWeightService(Guid id)
        {
            _repo.Delete(id);
        }

        public List<WeightService> GetWeightServiceCatalog()
        {
            return _repo.GetAll();
        }
    }
}
