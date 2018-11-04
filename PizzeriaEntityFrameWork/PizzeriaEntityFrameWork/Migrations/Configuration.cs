namespace PizzeriaEntityFrameWork.Migrations
{
    using CsvHelper;
    using PizzeriaEntityFrameWork.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Configuration;
    using System.Xml.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PizzeriaEntityFrameWork.Models.PizzeriaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PizzeriaContext context)
        {
            #region Load_Ingredients
            if (!context.Ingredient.Any())
            {
                context.Ingredient.AddOrUpdate(
                    new Ingredient { IngredientId = 1, Name = "Tomate", Price = 0.10M },
                    new Ingredient { IngredientId = 2, Name = "Queso", Price = 1.10M },
                    new Ingredient { IngredientId = 3, Name = "Oregano", Price = 0.05M },
                    new Ingredient { IngredientId = 4, Name = "Jamon", Price = 0.90M },
                    new Ingredient { IngredientId = 5, Name = "Piña", Price = 1M }
                    );
            }
            #endregion
           
        }
    }
 }

