using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaEntityFrameWork.Models;

namespace PizzeriaEntityFrameWork.Repository
{
    class IngredientsRepository:DbContext, IIngredientsRepository
    {
        private IPizzeriaContext _context;
        public IngredientsRepository(IPizzeriaContext context)
        {
            this._context = context;
        }
        public void Add(Ingredient entity)
        {
            _context.Ingredient.Add(entity);
        }
        public void Delete(Ingredient entity)
        {
            _context.Ingredient.Remove(entity);
        }
        public void Update(Ingredient entity)
        {
            var result = _context.Ingredient.SingleOrDefault(x => x.IngredientId == entity.IngredientId);
        }
    }
}
