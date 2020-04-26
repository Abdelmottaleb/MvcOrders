using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using MvcOrders.Models;

namespace MvcOrders.ViewModels
{
    public class ProductListViewModel
    {
        public List<Product> Orderedproducts;

        public int Amount=0;

        public int ShoppingCartTotal=0;

        public ProductListViewModel(IEnumerable<Product> products)
        {
            this.Products = products;
            Orderedproducts = new List<Product>();
            selectedProduct = new Product();
            
        }
        
        [Display(Name = "Name")]
        public string SelectedName;
        public IEnumerable<Product> Products { get; set; }

         [ViewData]
        public Product selectedProduct { get; set; }
    }
}