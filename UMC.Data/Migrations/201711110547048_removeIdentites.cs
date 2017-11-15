namespace UMC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeIdentites : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stations", "StationName", c => c.String());
            DropColumn("dbo.Stations", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stations", "Name", c => c.String());
            DropColumn("dbo.Stations", "StationName");
        }
    }
}
