using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furnit.Interfaces.EntityInterfaces;

namespace Furnit.Entities 
{
    public class Charasteristics_Item : IItems<int>
    {
        public int Id_Item { get; set; }
        public int Width_it { get; set; }
        public int Height_it { get; set; }
        public int Length_it { get; set; }
        public string Colour_it { get; set; }

    }
}
