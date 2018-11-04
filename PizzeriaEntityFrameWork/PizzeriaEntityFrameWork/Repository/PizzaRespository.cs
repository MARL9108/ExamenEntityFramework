using PizzeriaEntityFrameWork.Models;
using PizzeriaEntityFrameWork.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PizzeriaEntityFrameWork.Infrastructure
{
    class PizzaRespository: DbContext, IRepository<Pizza>
    {
        private IPizzeriaContext _context;
        public PizzaRespository(IPizzeriaContext context)
        {
            this._context = context;
        }
        public void Add(Pizza entity)
        {
            _context.Pizza.Add(entity);
        }
        public IEnumerable<Pizza> GetAll()
        {
            return _context.Pizza.AsEnumerable<Pizza>();
        }
        public Pizza GetById(Pizza pizza)
        {
            return _context.Pizza.Find(pizza.PizzaId);
        }
    }
}
