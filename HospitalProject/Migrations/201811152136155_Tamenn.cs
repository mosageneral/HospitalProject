namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tamenn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tamen", "Address", c => c.String(nullable: false));
            AddColumn("dbo.Tamen", "PhoneNumber", c => c.String(nullable: false));
            AddColumn("dbo.Tamen", "Agent", c => c.String(nullable: false));
            AddColumn("dbo.Tamen", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Tamen", "WebSite", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tamen", "WebSite");
            DropColumn("dbo.Tamen", "Email");
            DropColumn("dbo.Tamen", "Agent");
            DropColumn("dbo.Tamen", "PhoneNumber");
            DropColumn("dbo.Tamen", "Address");
        }
    }
}
