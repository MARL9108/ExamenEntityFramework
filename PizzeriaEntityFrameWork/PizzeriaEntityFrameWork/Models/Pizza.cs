using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaEntityFrameWork.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string Name { get; set; }
        public byte[] Photo { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public decimal Price()
        {
            var profit = Convert.ToDecimal(ConfigurationManager.AppSettings["Profit"]);
            var Price = Ingredients.Sum(x => x.Price) + profit;
            return Price;
        }
    }
}
