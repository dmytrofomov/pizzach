using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class PizzaRepository : BaseRepository
    {
        public async Task<Pizza> GetPizzaById(int id)
        {
            return await Db.Pizzas.FindAsync(id);
        }

        public List<Pizza> GetAllPizzas()
        {
            return Db.Pizzas.Include(p => p.Ingridients).ThenInclude(i => i.Component).ToList();
        }

        public async Task<bool> AddComponent(Component c)
        {
            Db.Components.Add(c);
            await Db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AddPizza(Pizza p)
        {
            Db.Pizzas.Add(p);
            await Db.SaveChangesAsync();
            return true;
        }

        public async Task<Pizza> GetPizzaByName(string pizzaName)
        {
            return await Db.Pizzas.FirstOrDefaultAsync(p => p.Name == pizzaName);
        }

        public async Task<Component> GetComponentByName(string componentName)
        {
            return await Db.Components.FirstOrDefaultAsync(c => c.Name == componentName);
        }

        public async Task AddIngridient(Pizza pizza, Component component)
        {
            await Db.Ingridients.AddAsync(new Ingridients {ComponentId = component.Id, PizzaId = pizza.Id});
        }

        public async Task SaveChanges()
        {
            await Db.SaveChangesAsync();
        }

    }
}
