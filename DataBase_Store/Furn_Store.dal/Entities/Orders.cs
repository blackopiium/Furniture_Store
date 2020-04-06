using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furnit.Entities
{
    public class Orders
    {
        public int Id_Order { get; set; }
        public string Id_Client { get; set; }
        public decimal Price { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Apartment { get; set; }

    }
}
