using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcOrders.Models;
using MvcOrders.services;
using MvcOrders.ViewModels;
using System.Linq;

namespace MvcOrders.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        IEnumerable<Product> products;
        ProductListViewModel vm;

       

        public ProductController(IProductService productSvc)
        {
            productService = productSvc;
            this.products = this.productService.GetProducts();
            vm = new ProductListViewModel( this.products);
            vm.Products=products;
        }

        public ViewResult ProductList()
        {
            vm.Orderedproducts = products.ToList(); //for test
            return View(vm);
        }

        public IActionResult  selectProduct(string Name)
        {
            var selectedProduct = this.products.FirstOrDefault(p => p.Name.Equals(Name));
            //ProductListViewModel vm = new ProductListViewModel(products);
            if (selectedProduct != null)
            {
                this.vm.selectedProduct = selectedProduct;
                ViewData["Model"] = vm;
            }
            return  RedirectToAction("ProductList", vm);
        }

            public RedirectToActionResult RemoveFromShoppingCart(string Name)
        {
            System.Console.Beep();
             System.Console.Write("test = "+Name);
            var selectedProduct = this.products.FirstOrDefault(p => p.Name.Equals(Name));
            if (selectedProduct != null)
            {
                vm.Orderedproducts.Remove(selectedProduct);
            }
            return RedirectToAction("ProductList");
        }

           public RedirectToActionResult AddToShoppingCart(string Name)
        {
              System.Console.Beep();
              var x = this.vm.selectedProduct;
            var Product = this.products.FirstOrDefault(p => p.Name.Equals(Name));
            if (Product != null && !this.products.Contains(Product))
            {
                vm.Orderedproducts.Add(Product);
                vm.Amount++;
            }
            return RedirectToAction("ProductList");
        }

       
    }
}