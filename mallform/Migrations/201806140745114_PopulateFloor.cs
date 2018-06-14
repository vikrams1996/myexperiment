namespace mallform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateFloor : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Floors (Id , Name) VALUES (1, 'first')");
            Sql("INSERT INTO Floors (Id , Name) VALUES (2, 'Second')");
            Sql("INSERT INTO Floors (Id , Name) VALUES (3, 'Third')");
            Sql("INSERT INTO Floors (Id , Name) VALUES (4, 'fourth')");
            Sql("INSERT INTO Floors (Id , Name) VALUES (5, 'fifth')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Floors WHERE in Id (1, 2, 3, 4, 5)");
        }
    }
}
