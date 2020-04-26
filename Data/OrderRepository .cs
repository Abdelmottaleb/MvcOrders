using MvcOrders.Models;

namespace MvcOrders.Data
{
    public class OrderRepository : IOrderRepository
    {
         private readonly MvcOrderContext _context;

         public OrderRepository(MvcOrderContext context)
        {
            _context = context;
        }

        public async System.Threading.Tasks.Task CreateOrder(Order order)
        {
             _context.Add(order);
            await _context.SaveChangesAsync();
        }
    }
}