using System;
using DataLayer.Models;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PizzaContext db = new PizzaContext())
            {
                Pizza pizza = new Pizza { Name = "Napoli" };
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine($"Id перед добавлением в контекст {pizza.Id}");    // Id = 0
                db.Pizzas.Add(pizza);
                db.SaveChanges();
                Console.WriteLine($"Id после добавления в базу данных {pizza.Id}");  // Id = 3
            }
        }
    }
}
