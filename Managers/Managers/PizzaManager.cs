using Data.Repositories;
using DataLayer.Models;
using Managers.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Managers.Managers
{
    public class PizzaManager
    {
        PizzaRepository rep = new PizzaRepository();

        public async Task<bool> AddComponent(ComponentModel component)
        {
            if (component.Weight == 0 || component.Price == 0)
            {
                return false;
            }
            Component c = new Component
            {
                Name = component.Name,
                Weight = component.Weight,
                Price = component.Price
            };
            return await rep.AddComponent(c);
        }

        public async Task<Pizza> GetPizzaById(int id)
        {
            return await rep.GetPizzaById(id);
        }

        public List<Pizza> GetAllPizzas()
        {
            return rep.GetAllPizzas();
        }

        public async Task AddPizza(PizzaModel pizza)
        {
            if (pizza.Size == 0 )
            {
                return;
            }

            var p = new Pizza()
            {
                Price = pizza.Price,
                Name = pizza.Name,
                Size = pizza.Size
            };
            await rep.AddPizza(p);

            var pizzaRep = rep.GetPizzaByName(pizza.Name).Result;

            foreach (var c in pizza.Components)
            {
                var componentRep = rep.GetComponentByName(c.Name).Result;
                await rep.AddIngridient(pizzaRep, componentRep);
            }

            await rep.SaveChanges();
        }
    }
}
