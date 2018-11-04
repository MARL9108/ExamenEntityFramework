using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaEntityFrameWork.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int PizzaId { get; set; }
        public virtual Pizza Pizza { get; set; }
    }
}
