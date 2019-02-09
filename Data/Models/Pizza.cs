using DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Pizza
    {
        public string Name { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public int Price { get; set; }
        public List<string> Components { get; set; }
    }
}
