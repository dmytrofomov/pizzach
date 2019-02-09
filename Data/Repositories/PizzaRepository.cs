using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class PizzaRepository : BaseRepository
    {
        public async Task<Pizza> GetPizzaById(int id)
        {
            return await Db.Pizzas.FindAsync(id);
        }
    }
}
