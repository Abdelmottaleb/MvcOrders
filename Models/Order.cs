using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MvcOrders.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

         public List<OrderDetail> OrderLines { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public System.DateTime OrderCreatedDate { get; set; }
    }
}