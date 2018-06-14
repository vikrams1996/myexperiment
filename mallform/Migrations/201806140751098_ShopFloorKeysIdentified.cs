namespace mallform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopFloorKeysIdentified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Units", "shopNo_Id", c => c.Int());
            AddColumn("dbo.shopNoes", "Floor_Id", c => c.Byte());
            CreateIndex("dbo.Units", "shopNo_Id");
            CreateIndex("dbo.shopNoes", "Floor_Id");
            AddForeignKey("dbo.shopNoes", "Floor_Id", "dbo.Floors", "Id");
            AddForeignKey("dbo.Units", "shopNo_Id", "dbo.shopNoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Units", "shopNo_Id", "dbo.shopNoes");
            DropForeignKey("dbo.shopNoes", "Floor_Id", "dbo.Floors");
            DropIndex("dbo.shopNoes", new[] { "Floor_Id" });
            DropIndex("dbo.Units", new[] { "shopNo_Id" });
            DropColumn("dbo.shopNoes", "Floor_Id");
            DropColumn("dbo.Units", "shopNo_Id");
        }
    }
}
