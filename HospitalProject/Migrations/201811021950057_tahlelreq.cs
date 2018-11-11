namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tahlelreq : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tahlelreqs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TahlelId = c.Int(nullable: false),
                        PateintName = c.String(),
                        DateOfTahlel = c.DateTime(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tahlels", t => t.TahlelId, cascadeDelete: true)
                .Index(t => t.TahlelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tahlelreqs", "TahlelId", "dbo.Tahlels");
            DropIndex("dbo.tahlelreqs", new[] { "TahlelId" });
            DropTable("dbo.tahlelreqs");
        }
    }
}
