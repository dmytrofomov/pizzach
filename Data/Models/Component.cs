using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Component
    {
        public int Id { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Weight { get; set; }

        public ICollection<Ingridients> Ingridients { get; set; } = new HashSet<Ingridients>();
    }
}
