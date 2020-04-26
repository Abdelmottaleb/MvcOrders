using System.Collections.Generic;
using MvcOrders.Data;
using MvcOrders.Models;

namespace MvcOrders.services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        public ProductService(IProductRepository productRepo)
        {
            productRepository = productRepo;
        }
        public IEnumerable<Product> GetProducts()
        {
            return this.productRepository.Products;
        }
    }
}