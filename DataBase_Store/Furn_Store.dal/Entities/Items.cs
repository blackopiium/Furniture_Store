using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furnit.Interfaces.EntityInterfaces;

namespace Furnit.Entities
{
    public class Items : IItems<int>
    {
        public int Id_Item {get; set;}
        public string Id_Name { get; set; }
        public int Id_Category { get; set; }
        public decimal Price { get; set; }
        public int Id_Factory { get; set; }
       /* public int Id_Order { get; set; }
        public int Width_it { get; set; }
        public int Height_it { get; set; }
        public int Length_it { get; set; }
        public string Colour_it { get; set; }*/
    }
}
