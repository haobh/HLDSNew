namespace UMC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quantities", "LineID", c => c.Int(nullable: false));
            AddColumn("dbo.Quantities", "number", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Quantities", "Type", c => c.String());
            CreateIndex("dbo.Quantities", "LineID");
            AddForeignKey("dbo.Quantities", "LineID", "dbo.Lines", "ID", cascadeDelete: true);
            DropColumn("dbo.Quantities", "TimeInput");
            DropColumn("dbo.Quantities", "Time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Quantities", "Time", c => c.String());
            AddColumn("dbo.Quantities", "TimeInput", c => c.String());
            DropForeignKey("dbo.Quantities", "LineID", "dbo.Lines");
            DropIndex("dbo.Quantities", new[] { "LineID" });
            DropColumn("dbo.Quantities", "Type");
            DropColumn("dbo.Quantities", "number");
            DropColumn("dbo.Quantities", "LineID");
        }
    }
}
