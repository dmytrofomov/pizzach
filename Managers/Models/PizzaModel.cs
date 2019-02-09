using DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Managers.Models
{
    public class PizzaModel
    {
        public string Name { get; set; }

        public PizzaSize Size { get; set; }

        public int Price { get; set; }

        public List<ComponentModel> Components { get; set; }
    }
}
