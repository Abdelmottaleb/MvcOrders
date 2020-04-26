using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using MvcOrders.Models;

namespace MvcOrders.Data
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }
        public IEnumerable<Product> Products
        {
            get
            {
                using (var jsonFileReader = File.OpenText(JsonFileName))
                {
                    return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });
                }
            }
        }


        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json"); }
        }
    }
}