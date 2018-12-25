namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class activate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activates",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        DateNow = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Activated = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Activates");
        }
    }
}
