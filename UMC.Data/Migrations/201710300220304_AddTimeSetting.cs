namespace UMC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTimeSetting : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TimeSettings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        T1 = c.Int(nullable: false),
                        T2 = c.Int(nullable: false),
                        T3 = c.Int(nullable: false),
                        T4 = c.Int(nullable: false),
                        T5 = c.Int(nullable: false),
                        T6 = c.Int(nullable: false),
                        T7 = c.Int(nullable: false),
                        T8 = c.Int(nullable: false),
                        T9 = c.Int(nullable: false),
                        T10 = c.Int(nullable: false),
                        T11 = c.Int(nullable: false),
                        T12 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TimeSettings");
        }
    }
}
