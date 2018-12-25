namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Hospitalinfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HospitalInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        ContactPhone = c.String(nullable: false),
                        ContactMobile = c.String(nullable: false),
                        Contactmobile2 = c.String(nullable: false),
                        DoctorName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HospitalInfoes");
        }
    }
}
