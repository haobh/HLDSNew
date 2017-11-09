namespace UMC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addColumnShift : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quantities", "ShiftCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quantities", "ShiftCode");
        }
    }
}
