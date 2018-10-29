namespace PizzeriaEntityFrameWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPizzaIngredient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredient",
                c => new
                    {
                        IngredientId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.IngredientId);
            
            CreateTable(
                "dbo.Pizza",
                c => new
                    {
                        PizzaId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PizzaId);
            
            CreateTable(
                "dbo.PizzaIngredient",
                c => new
                    {
                        Pizza_PizzaId = c.Int(nullable: false),
                        Ingredient_IngredientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Pizza_PizzaId, t.Ingredient_IngredientId })
                .ForeignKey("dbo.Pizza", t => t.Pizza_PizzaId, cascadeDelete: true)
                .ForeignKey("dbo.Ingredient", t => t.Ingredient_IngredientId, cascadeDelete: true)
                .Index(t => t.Pizza_PizzaId)
                .Index(t => t.Ingredient_IngredientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PizzaIngredient", "Ingredient_IngredientId", "dbo.Ingredient");
            DropForeignKey("dbo.PizzaIngredient", "Pizza_PizzaId", "dbo.Pizza");
            DropIndex("dbo.PizzaIngredient", new[] { "Ingredient_IngredientId" });
            DropIndex("dbo.PizzaIngredient", new[] { "Pizza_PizzaId" });
            DropTable("dbo.PizzaIngredient");
            DropTable("dbo.Pizza");
            DropTable("dbo.Ingredient");
        }
    }
}
