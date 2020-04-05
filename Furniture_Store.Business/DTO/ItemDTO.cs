using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Store.Business.DTO
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public float Price { get; set; }
        public int FactoryId { get; set; }
      
    }
}
