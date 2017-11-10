namespace UMC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTimeDaily : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TimeDailies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Time1 = c.Int(nullable: false),
                        Time2 = c.Int(nullable: false),
                        Time3 = c.Int(nullable: false),
                        Time4 = c.Int(nullable: false),
                        Time5 = c.Int(nullable: false),
                        Time6 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TimeDailies");
        }
    }
}
