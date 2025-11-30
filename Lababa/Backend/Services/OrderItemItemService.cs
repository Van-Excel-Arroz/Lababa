
using Lababa.Backend.Data;
using Lababa.Backend.Models;

namespace Lababa.Backend.Services
{
    public class OrderItemItemService
    {
        private readonly LababaDbContext _context;

        public OrderItemItemService(LababaDbContext context)
        {
            _context = context;
        }

        public void Delete(Guid id)
        {
            var item = _context.OrderItemItems.Find(id);
            if (item != null)
            {
                _context.OrderItemItems.Remove(item);
                _context.SaveChanges();
            }
        }

        public List<OrderItemItem> GetAll(Guid orderId)
        {
            return _context.OrderItemItems.Where(oi => oi.OrderId == orderId).ToList();
        }


        public void Add(OrderItemItem item)
        {
            _context.OrderItemItems.Add(item);
            _context.SaveChanges();
        }
    }
}
