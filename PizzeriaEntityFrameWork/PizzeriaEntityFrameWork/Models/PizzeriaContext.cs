namespace PizzeriaEntityFrameWork.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using PizzeriaEntityFrameWork.Repository;

    public class PizzeriaContext : DbContext,IPizzeriaContext

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
        public new void Dispose()
        {
            base.Dispose();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            #region Pizza_Validations
            modelBuilder.Entity<Pizza>().Property(x => x.PizzaId)
                                        .IsRequired();
            modelBuilder.Entity<Pizza>().Property(x => x.Name)
                                        .IsRequired()
                                        .HasMaxLength(50);
            #endregion
            #region Comments_Validations
            modelBuilder.Entity<Comment>().Property(x => x.Text)
                                          .IsRequired()
                                          .HasMaxLength(200);
            modelBuilder.Entity<Comment>().Property(x => x.Score)
                                          .IsRequired();
            modelBuilder.Entity<Comment>().Property(x => x.Score)
                                          .IsRequired();
            modelBuilder.Entity<Comment>().Property(x => x.User)
                                          .IsRequired();
            #endregion
            #region Relations
            modelBuilder.Entity<Comment>()
                        .HasRequired<Pizza>(x => x.Pizza)
                        .WithMany(x => x.Comments)
                        .HasForeignKey<int>(x => x.PizzaId);
            modelBuilder.Entity<Ingredient>()
                        .HasRequired<Pizza>(x => x.Pizza)
                        .WithMany(x => x.Ingredients)
                        .HasForeignKey<int>(x => x.PizzaId);
            #endregion
        }

    }


}