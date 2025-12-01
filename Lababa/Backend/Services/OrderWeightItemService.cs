
using Lababa.Backend.Data;
using Lababa.Backend.Models;

namespace Lababa.Backend.Services
{
    public class OrderWeightItemService
    {
        private readonly LababaDbContext _context;

        public OrderWeightItemService(LababaDbContext context)
        {
            _context = context;
        }

        public void Delete(Guid id)
        {
            var item = _context.OrderWeightItems.Find(id);
            if (item != null)
            {
                _context.OrderWeightItems.Remove(item);
                _context.SaveChanges();
            }
        }
        public List<OrderWeightItem> GetAll(Guid orderId)
        {
            return _context.OrderWeightItems.Where(ow => ow.OrderId == orderId).ToList();
        }

        public void Add(OrderWeightItem item)
        {
            _context.OrderWeightItems.Add(item);
            _context.SaveChanges();
        }
    }
}
