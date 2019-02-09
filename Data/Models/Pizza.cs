using DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;

namespace DataLayer.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public PizzaSize Size { get; set; }

        public int Price { get; set; }

        public ICollection<Ingridients> Ingridients { get; set; } = new HashSet<Ingridients>();

    }
}
