namespace PizzeriaEntityFrameWork.Migrations
{
    using PizzeriaEntityFrameWork.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PizzeriaEntityFrameWork.Models.PizzeriaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PizzeriaContext context)
        {
            context.Pizza.AddOrUpdate(
                new Pizza { PizzaId = 1, Name = "Carbonara" },
                new Pizza { PizzaId = 2, Name = "Cuatro Quesos" }
                );
            context.Ingredient.AddOrUpdate(
                new Ingredient { IngredientId = 1, Name = "Tomate", Price = 0.20M },
                new Ingredient { IngredientId = 2, Name = "Queso", Price = 1 }
                );
            
        }
    }
}
