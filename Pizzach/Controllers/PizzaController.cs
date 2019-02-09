using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Repositories;
using DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pizzach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private PizzaRepository PizzaRepository { get; }

        public PizzaController(PizzaRepository pizzaRepository)
        {
            PizzaRepository = pizzaRepository;
        }

        [HttpGet("{id}")]
        public async Task<Pizza> GetPizzaById(int id)
        {
            return await PizzaRepository.GetPizzaById(id);
        }
    }
}