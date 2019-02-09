using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Components
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public List<string> UsedInPizza { get; set; }
    }
}
