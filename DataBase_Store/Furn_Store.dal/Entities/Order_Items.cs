using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furnit.Interfaces.EntityInterfaces;

namespace Furnit.Entities
{
    public class Order_Items : IItems<int>
    {
        public int Id_Order { get; set; }
        public int Id_Item { get; set; }
        public int Count_of_item { get; set; }
    }
}
