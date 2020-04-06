using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furnit.Interfaces;
using Furnit.Interfaces.EntityInterfaces;

namespace Furnit.Entities
{
    public class Category
    {
        public int Id_Category { get; set; }
        public string Category_name { get; set; }
        public string Description_Cat { get; set; }
    }
}
