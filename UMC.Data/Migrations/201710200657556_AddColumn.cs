namespace UMC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LineStations",
                c => new
                    {
                        LineId = c.Int(nullable: false),
                        StationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.LineId, t.StationId })
                .ForeignKey("dbo.Lines", t => t.LineId, cascadeDelete: true)
                .ForeignKey("dbo.Stations", t => t.StationId, cascadeDelete: true)
                .Index(t => t.LineId)
                .Index(t => t.StationId);
            
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Quantities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        TimeInput = c.String(),
                        Time = c.String(),
                        T1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        T2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        T3 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        T4 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        T5 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        T6 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        T7 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        T8 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        T9 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        T10 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        T11 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        T12 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StationID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Stations", t => t.StationID, cascadeDelete: true)
                .Index(t => t.StationID);
            
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        StartHour = c.Int(nullable: false),
                        EndHour = c.Int(nullable: false),
                        StartMinute = c.Int(nullable: false),
                        EndMinute = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Quantities", "StationID", "dbo.Stations");
            DropForeignKey("dbo.LineStations", "StationId", "dbo.Stations");
            DropForeignKey("dbo.LineStations", "LineId", "dbo.Lines");
            DropIndex("dbo.Quantities", new[] { "StationID" });
            DropIndex("dbo.LineStations", new[] { "StationId" });
            DropIndex("dbo.LineStations", new[] { "LineId" });
            DropTable("dbo.Shifts");
            DropTable("dbo.Quantities");
            DropTable("dbo.Stations");
            DropTable("dbo.LineStations");
            DropTable("dbo.Lines");
        }
    }
}
