namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Workers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Job = c.String(nullable: false),
                        Age = c.String(nullable: false),
                        Salary = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Phone = c.Int(nullable: false),
                        Describ = c.String(nullable: false),
                        CardId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Workers");
        }
    }
}
