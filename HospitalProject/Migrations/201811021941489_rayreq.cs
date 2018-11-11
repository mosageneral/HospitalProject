namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rayreq : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rayreqs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RayId = c.Int(nullable: false),
                        PateintName = c.String(),
                        DateOfRay = c.DateTime(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rays", t => t.RayId, cascadeDelete: true)
                .Index(t => t.RayId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rayreqs", "RayId", "dbo.Rays");
            DropIndex("dbo.Rayreqs", new[] { "RayId" });
            DropTable("dbo.Rayreqs");
        }
    }
}
