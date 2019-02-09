using Data.Models;
using DataLayer.Enums;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzach.WebModels
{
    public class PizzaModel
    {

        public string Name { get; set; }

        public PizzaSize PizzaSize { get; set; }

        public int Price { get; set; }

        public List<Component> Ingridients { get; set; } 
    }
}
