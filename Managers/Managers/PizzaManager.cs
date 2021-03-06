﻿using Data.Repositories;
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

        public List<PizzaModel> GetAllPizzas()
        {
            List<Pizza> pizzas = rep.GetAllPizzas();
            List<PizzaModel> pizzaModels = new List<PizzaModel>();
            
            foreach (var p in pizzas)
            {
                List<ComponentModel> componentModel = new List<ComponentModel>();

                foreach (var ingridient in p.Ingridients)
                {
                    componentModel.Add(new ComponentModel
                    {
                        Name = ingridient.Component.Name,
                        Price = ingridient.Component.Price,
                        Weight = ingridient.Component.Weight
                    });
                    
                }
                pizzaModels.Add(new PizzaModel
                {
                    Name = p.Name, Price = p.Price, Size = p.Size, Components = componentModel
                });
            }

            return pizzaModels;
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
