using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Furniture_Store.Data;

namespace Furniture_Store.Models
{
   /* [Table("Order_Items")]*/
    public class Order_Items : IEntity<int>
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Count_of_items { get; set; }
        public Item Item { get; set; }
        public Order Order { get; set; }
    }
}
