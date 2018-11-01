namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FristPatinet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adwyas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Content0 = c.String(nullable: false),
                        Content1 = c.String(),
                        Content2 = c.String(),
                        Content3 = c.String(),
                        Content4 = c.String(),
                        Content5 = c.String(),
                        Content6 = c.String(),
                        Content7 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PatientHagzs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                        KashfDate = c.DateTime(nullable: false),
                        Number = c.String(nullable: false),
                        MaradId = c.Int(nullable: false),
                        TamenId = c.Int(nullable: false),
                        IsBaid = c.Boolean(nullable: false),
                        Tashkhees = c.String(),
                        Rosheta = c.String(),
                        Esteshara = c.DateTime(),
                        AdwyaId = c.Int(nullable: false),
                        RayId = c.Int(nullable: false),
                        TahlelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adwyas", t => t.AdwyaId, cascadeDelete: true)
                .ForeignKey("dbo.Marads", t => t.MaradId, cascadeDelete: true)
                .ForeignKey("dbo.Rays", t => t.RayId, cascadeDelete: true)
                .ForeignKey("dbo.Tahlels", t => t.TahlelId, cascadeDelete: true)
                .ForeignKey("dbo.Tamen", t => t.TamenId, cascadeDelete: true)
                .Index(t => t.MaradId)
                .Index(t => t.TamenId)
                .Index(t => t.AdwyaId)
                .Index(t => t.RayId)
                .Index(t => t.TahlelId);
            
            CreateTable(
                "dbo.Marads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tahlels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tamen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PatientHagzs", "TamenId", "dbo.Tamen");
            DropForeignKey("dbo.PatientHagzs", "TahlelId", "dbo.Tahlels");
            DropForeignKey("dbo.PatientHagzs", "RayId", "dbo.Rays");
            DropForeignKey("dbo.PatientHagzs", "MaradId", "dbo.Marads");
            DropForeignKey("dbo.PatientHagzs", "AdwyaId", "dbo.Adwyas");
            DropIndex("dbo.PatientHagzs", new[] { "TahlelId" });
            DropIndex("dbo.PatientHagzs", new[] { "RayId" });
            DropIndex("dbo.PatientHagzs", new[] { "AdwyaId" });
            DropIndex("dbo.PatientHagzs", new[] { "TamenId" });
            DropIndex("dbo.PatientHagzs", new[] { "MaradId" });
            DropTable("dbo.Tamen");
            DropTable("dbo.Tahlels");
            DropTable("dbo.Rays");
            DropTable("dbo.Marads");
            DropTable("dbo.PatientHagzs");
            DropTable("dbo.Adwyas");
        }
    }
}
