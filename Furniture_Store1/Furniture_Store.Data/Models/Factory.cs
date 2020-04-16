using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Furniture_Store.Data;

namespace Furniture_Store.Models
{
    [Table("Factory")]
    public class Factory : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; }
    }
}
