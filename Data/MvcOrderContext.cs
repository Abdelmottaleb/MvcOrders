using Microsoft.EntityFrameworkCore;
using MvcOrders.Models;

namespace MvcOrders.Data
{
    public class MvcOrderContext : DbContext
    {
        public MvcOrderContext (DbContextOptions<MvcOrderContext> options)
            : base(options)
        {
        }
         public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}