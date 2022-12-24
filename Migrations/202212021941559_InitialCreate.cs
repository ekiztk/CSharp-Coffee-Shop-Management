namespace CoffeShopManagement.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Label = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Products",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Label = c.String(),
                    Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Category_Id = c.Int(),
                    Order_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Order_Id);

            CreateTable(
                "dbo.Desks",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    DeskNumber = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Orders",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    IsReady = c.Boolean(nullable: false),
                    Desk_Id = c.Int(),
                    Employee_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Desks", t => t.Desk_Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Desk_Id)
                .Index(t => t.Employee_Id);

            CreateTable(
                "dbo.Employees",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    SocialSecurityNumber = c.Int(nullable: false),
                    Name = c.String(),
                    Role_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.Role_Id)
                .Index(t => t.Role_Id);

            CreateTable(
                "dbo.Roles",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Label = c.String(),
                    Permissions = c.String(),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Products", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Orders", "Desk_Id", "dbo.Desks");
            DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Employees", new[] { "Role_Id" });
            DropIndex("dbo.Orders", new[] { "Employee_Id" });
            DropIndex("dbo.Orders", new[] { "Desk_Id" });
            DropIndex("dbo.Products", new[] { "Order_Id" });
            DropIndex("dbo.Products", new[] { "Category_Id" });
            DropTable("dbo.Roles");
            DropTable("dbo.Employees");
            DropTable("dbo.Orders");
            DropTable("dbo.Desks");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
