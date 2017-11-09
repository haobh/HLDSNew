namespace UMC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditTableQuantities : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quantities", "NumberConfig", c => c.Single());
            AlterColumn("dbo.Quantities", "T1", c => c.Single());
            AlterColumn("dbo.Quantities", "T2", c => c.Single());
            AlterColumn("dbo.Quantities", "T3", c => c.Single());
            AlterColumn("dbo.Quantities", "T4", c => c.Single());
            AlterColumn("dbo.Quantities", "T5", c => c.Single());
            AlterColumn("dbo.Quantities", "T6", c => c.Single());
            AlterColumn("dbo.Quantities", "T7", c => c.Single());
            AlterColumn("dbo.Quantities", "T8", c => c.Single());
            AlterColumn("dbo.Quantities", "T9", c => c.Single());
            AlterColumn("dbo.Quantities", "T10", c => c.Single());
            AlterColumn("dbo.Quantities", "T11", c => c.Single());
            AlterColumn("dbo.Quantities", "T12", c => c.Single());
            DropColumn("dbo.Quantities", "number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Quantities", "number", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Quantities", "T12", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Quantities", "T11", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Quantities", "T10", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Quantities", "T9", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Quantities", "T8", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Quantities", "T7", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Quantities", "T6", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Quantities", "T5", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Quantities", "T4", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Quantities", "T3", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Quantities", "T2", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Quantities", "T1", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Quantities", "NumberConfig");
        }
    }
}
