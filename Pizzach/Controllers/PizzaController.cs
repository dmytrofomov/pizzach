using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Repositories;
using DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Managers.Models;
using Managers.Managers;

namespace Pizzach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private PizzaManager PizzaManager { get; }

        public PizzaController(PizzaManager pizzaManager)
        {
            PizzaManager = pizzaManager;
        }

        [HttpGet("{id}")]
        public async Task<Pizza> GetPizzaById(int id)
        {
            return await PizzaManager.GetPizzaById(id);
        }

        public List<PizzaModel> GetAllPizza()
        {
            return PizzaManager.GetAllPizzas();
        }

        [HttpPost("addpizza")]
        public Task AddPizza([FromBody] PizzaModel pizza)
        {
            return PizzaManager.AddPizza(pizza);
        }

        [HttpPost("addcomponent")]
        public async Task<bool> AddComponent([FromBody] ComponentModel component)
        {
            return await PizzaManager.AddComponent(component);
        }
    }
}