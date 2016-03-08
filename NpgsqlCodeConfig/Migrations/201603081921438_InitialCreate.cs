namespace NpgsqlCodeConfig.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Clients",
                c => new
                    {
                        IdReg = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IdReg);
            
            CreateTable(
                "public.Products",
                c => new
                    {
                        IdReg = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.IdReg);
            
        }
        
        public override void Down()
        {
            DropTable("public.Products");
            DropTable("public.Clients");
        }
    }
}
