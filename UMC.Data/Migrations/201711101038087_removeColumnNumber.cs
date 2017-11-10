namespace UMC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeColumnNumber : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Quantities", "NumberConfig");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Quantities", "NumberConfig", c => c.Single());
        }
    }
}
