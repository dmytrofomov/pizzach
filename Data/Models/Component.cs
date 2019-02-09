using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Component
    {
        public int Id { get; set; }

       

        public int Price { get; set; }

        public string Name { get; set; }

        public int Weight { get; set; }

        public ICollection<Ingridients> Ingridients { get; set; } = new HashSet<Ingridients>();
    }
}
