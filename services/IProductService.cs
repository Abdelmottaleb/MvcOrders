using System.Collections.Generic;
using MvcOrders.Models;

namespace MvcOrders.services
{
    public interface IProductService
    {
         IEnumerable<Product> GetProducts();
    }
}