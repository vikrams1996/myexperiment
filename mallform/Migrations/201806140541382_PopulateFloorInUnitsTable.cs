namespace mallform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateFloorInUnitsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Units ( Floor) VALUES ( 'First')");
            Sql("INSERT INTO Units ( Floor) VALUES ( 'Second')");
            Sql("INSERT INTO Units ( Floor) VALUES ( 'Third')");
            Sql("INSERT INTO Units ( Floor) VALUES ( 'Fourth')");
            Sql("INSERT INTO Units (Floor) VALUES ('Fifth')");
        }
        
        public override void Down()
        {
        
        }
    }
}
