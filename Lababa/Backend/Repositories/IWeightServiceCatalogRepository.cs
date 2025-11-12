using Lababa.Backend.Models;
using System;
using System.Collections.Generic;

namespace Lababa.Backend.Repositories
{
    public interface IWeightServiceCatalogRepository
    {
        List<WeightService> GetAll();
        WeightService GetById(Guid id);
        void Add(WeightService weigthService);
        void Update(WeightService weigthService);
        void Delete(Guid id);
    }
}
