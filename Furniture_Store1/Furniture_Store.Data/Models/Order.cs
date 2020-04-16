using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Furniture_Store.Data;


namespace Furniture_Store.Models
{
    [Table("Order")]
    public class Order : IEntity<int>
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public float Price { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Apartment { get; set; }
        public List<Order_Items> Order_Items { get; set; }
        public Client Client { get; set; }
    }
}
