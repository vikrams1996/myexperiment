namespace mallform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableShopNoAndFloor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Floors",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.shopNoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.shopNoes");
            DropTable("dbo.Floors");
        }
    }
}
