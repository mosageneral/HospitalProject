namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class amalyat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Amaleyats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PatientName = c.String(),
                        Price = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        IsDone = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Amaleyats");
        }
    }
}
