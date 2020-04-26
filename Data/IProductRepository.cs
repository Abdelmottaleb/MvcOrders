using System.Collections.Generic;
using MvcOrders.Models;

namespace MvcOrders.Data
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}