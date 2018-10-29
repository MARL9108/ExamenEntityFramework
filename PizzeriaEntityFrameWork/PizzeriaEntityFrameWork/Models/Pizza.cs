using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaEntityFrameWork.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string Name { get; set; }

        public List<Ingredient> Ingredients { get; set; }
    }
}
