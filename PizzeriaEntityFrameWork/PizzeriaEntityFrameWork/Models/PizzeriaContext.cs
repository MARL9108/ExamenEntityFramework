namespace PizzeriaEntityFrameWork.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using PizzeriaEntityFrameWork.Repository;

    public class PizzeriaContext : DbContext
    {
        public IDbSet<Pizza> Pizza { get; set; }
        public IDbSet<Ingredient> Ingredient {get; set;}

        public PizzeriaContext(): base("name=PizzeriaContext")
        {
        }
        public void Commit()
        {
            base.SaveChanges();
        }
        public void Rollback ()
        {
            base.ChangeTracker.Entries().ToList().ForEach(x => x.State = EntityState.Unchanged);
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
            #endregion
            
           
        }

    }


}