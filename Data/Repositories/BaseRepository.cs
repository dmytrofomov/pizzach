using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class BaseRepository
    {
        protected  readonly PizzaContext Db;
        protected BaseRepository()
        {
            Db = new PizzaContext();
        }
    }
}
