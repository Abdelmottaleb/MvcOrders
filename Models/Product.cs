using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MvcOrders.Models
{
    public class Product
    {
      public int ProductId { get; set; }

       [JsonPropertyName("Name")]
       [Display(Name="Product Name")]
       [Required(ErrorMessage="Please choose one product")]
        public string Name { get; set; }

        [JsonPropertyName("Price")]
        public decimal Price { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}