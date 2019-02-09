using DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Ingridients
    {
        public int Id { get; set; }

        public int PizzaId { get; set; }

        [ForeignKey(nameof(PizzaId))]
        public Pizza Pizza { get; set; }

        public int ComponentId { get; set; }

        [ForeignKey(nameof(ComponentId))]
        public Component Component { get; set; }

    }
}
