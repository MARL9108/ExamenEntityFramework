using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaEntityFrameWork.Models;

namespace PizzeriaEntityFrameWork.Repository
{
    class IngredientRepository:IIngredientsRepository
    {
        private PizzeriaContext context;
        public IngredientRepository(PizzeriaContext context)
        {
            this.context = context;
        }
        public Ingredient GetIngredientId(int IngredientId)
        {
            return context.Ingredient.Find(IngredientId);
        }
        public void InsertIngredient(Ingredient ingredient)
        {
            context.Ingredient.Add(ingredient);
        }
        public void DeleteIngredient(int IngredientId)
        {
            Ingredient ingredient = context.Ingredient.Find(IngredientId);
            context.Ingredient.Remove(ingredient);
        }
        public void UpdateIngredient(Ingredient ingredient)
        {
            context.Entry(ingredient).State = EntityState.Modified;
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
