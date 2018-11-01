using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;

namespace PizzeriaEntityFrameWork.Models
{
    public class Pizza_Ingredient
    {
        public int PizzaId { get; set; }
        public int IngredientId { get; set; }

        public virtual Pizza Pizza { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }

       
        public int IngredientAmount
        {
            get
            {
                var Amount = Pizza.Ingredients.Sum(x => x.IngredientId);
                if (Amount < 1)
                {
                    throw new Exception("Incorrect Amount");
                }
                return Amount;
            }

        }
    }
}
