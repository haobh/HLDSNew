namespace UMC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addColumnNumberConfig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stations", "NumberConfig", c => c.Single());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stations", "NumberConfig");
        }
    }
}
