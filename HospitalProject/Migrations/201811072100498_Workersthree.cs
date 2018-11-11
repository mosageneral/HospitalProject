namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Workersthree : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Workers", "Describ", c => c.String());
            DropColumn("dbo.Workers", "CardNum");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Workers", "CardNum", c => c.Int(nullable: false));
            AlterColumn("dbo.Workers", "Describ", c => c.String(nullable: false));
        }
    }
}
