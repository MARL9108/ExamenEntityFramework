using PizzeriaEntityFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PizzeriaEntityFrameWork.Repository
{
    class PizzaRepository:IPizzaRepository
    {
        private PizzeriaContext context;
        public PizzaRepository(PizzeriaContext context)
        {
            this.context = context;
        }
        public Pizza GetPizzaId(int PizzaId)
        {
            return context.Pizza.Find(PizzaId);
        }
        public void InsertPizza(Pizza pizza)
        {
            context.Pizza.Add(pizza);
        }
        public void DeletePizza(int PizzaId)
        {
            Pizza pizza = context.Pizza.Find(PizzaId);
            context.Pizza.Remove(pizza);
        }
        public void UpdatePizza(Pizza pizza)
        {
            context.Entry(pizza).State = EntityState.Modified;
        }
        public void Save()
        {
            context.SaveChanges();
        }
        public void Dispose()
        {
        }
    }
}
