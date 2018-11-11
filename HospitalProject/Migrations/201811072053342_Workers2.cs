namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Workers2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Workers", "CardNum", c => c.Int(nullable: false));
            AlterColumn("dbo.Workers", "Phone", c => c.String(nullable: false));
            DropColumn("dbo.Workers", "CardId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Workers", "CardId", c => c.Int(nullable: false));
            AlterColumn("dbo.Workers", "Phone", c => c.Int(nullable: false));
            DropColumn("dbo.Workers", "CardNum");
        }
    }
}
