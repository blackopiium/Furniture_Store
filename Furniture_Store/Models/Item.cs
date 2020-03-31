using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Furniture_Store.Data;

namespace Furniture_Store.Models
{
    [Table("Item")]
    public class Item : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public float Price { get; set; }
        public int FactoryId { get; set; }
        public Charachteristics_Item Charachteristics_Item { get; set; }
        public Category Category { get; set; }
        public Factory Factory { get; set; }
        public List<Order_Items> Order_Items { get; set; }

    }
}
