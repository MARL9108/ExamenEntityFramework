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
            #region Prueba
            /*var resourceName = "PizzeriaEntityFrameWork.SeedData.Ingredients.csv";
            var assembly = Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream(resourceName);
            var xml = XDocument.Load(stream);
            var ingredients = xml.Element("Ingredients")
                                 .Elements("Ingredient")
                                 .Select(x => new Ingredient
                                 {
                                     Name = (string)x.Element("Name"),
                                 }).ToArray();
            context.Ingredient.AddOrUpdate(c => c.Name, ingredients);
            
            Assembly assembly = Assembly.GetExecutingAssembly();
             string resourceName = "PizzeriaEntityFrameWork.SeedData.Ingredients.csv";
             using (Stream stream = assembly.GetManifestResourceStream(resourceName))
             {
                 using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                 {
                     CsvReader csvReader = new CsvReader(reader);
                     //csvReader.Configuration.WillThrowOnMissingField = false;
                     var records = csvReader.GetRecords<Ingredient>().ToArray();
                     foreach (Ingredient record in records)
                     {
                         context.Ingredient.AddOrUpdate(record);
                     }
                 }*/
            #endregion
        }
    }
    }

