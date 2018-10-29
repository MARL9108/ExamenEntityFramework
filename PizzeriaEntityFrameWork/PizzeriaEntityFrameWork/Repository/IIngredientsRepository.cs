using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaEntityFrameWork.Models;

namespace PizzeriaEntityFrameWork.Repository
{
    interface IIngredientsRepository:IDisposable
    {
        Ingredient GetIngredientId(int IngredientId);
        void InsertIngredient(Ingredient ingredient);
        void DeleteIngredient(int IngredientId);
        void UpdateIngredient(Ingredient ingredient);
        void Save();
    }
}
