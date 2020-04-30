using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Store.Data.Parameters
{
    public class ItemParameters : QueryStringParameters
    {
        public float minPrice { get; set; } = 0;
        public float maxPrice { get; set; } = float.MaxValue;
        public bool validPriceRange => maxPrice >= minPrice && minPrice >= 0;
    }
}
