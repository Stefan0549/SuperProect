namespace Project1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShoesMIgration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Size = c.Int(nullable: false),
                        ShoesTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShoesTypes", t => t.ShoesTypeId, cascadeDelete: true)
                .Index(t => t.ShoesTypeId);
            
            CreateTable(
                "dbo.ShoesTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shoes", "ShoesTypeId", "dbo.ShoesTypes");
            DropIndex("dbo.Shoes", new[] { "ShoesTypeId" });
            DropTable("dbo.ShoesTypes");
            DropTable("dbo.Shoes");
        }
    }
}
