namespace PizzeriaEntityFrameWork.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class PizzeriaContext : DbContext, IUnitOfWork
    {
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Ingredient> Ingredient {get; set;}

        public PizzeriaContext()
            : base("name=PizzeriaContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            #region Pizza
            modelBuilder.Entity<Pizza>().Property(x => x.PizzaId)
                                        .IsRequired();
            modelBuilder.Entity<Pizza>().Property(x => x.Name)
                                        .IsRequired()
                                        .HasMaxLength(50);
            //modelBuilder.Entity<Pizza_Ingredient>().Property(x=>x.PriceTotal)
                                                   
            #endregion
            #region Ingredient
            modelBuilder.Entity<Ingredient>().Property(x => x.IngredientId)
                                             .IsRequired();
            modelBuilder.Entity<Ingredient>().Property(x => x.Name)
                                             .IsRequired()
                                             .HasMaxLength(50);
            modelBuilder.Entity<Ingredient>().Property(x => x.Price)
                                             .IsRequired();
            #endregion
           
        }

    }


}