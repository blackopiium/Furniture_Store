using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Furniture_Store.Models
{
    [Table("Charachteristics_Item")]
    public class Charachteristics_Item
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Width_it { get; set; }
        public int Height_it { get; set; }
        public int Length_it { get; set; }
        public string Colour_it { get; set; }
        public Item Item;
    }
}
