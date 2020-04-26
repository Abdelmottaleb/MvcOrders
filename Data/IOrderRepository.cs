using MvcOrders.Models;

namespace MvcOrders.Data
{
    public interface IOrderRepository
    {
         System.Threading.Tasks.Task CreateOrder(Order order);
    }
}