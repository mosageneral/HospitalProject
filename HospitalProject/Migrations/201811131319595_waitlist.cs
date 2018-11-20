namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class waitlist : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientHagzs", "EndTurn", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PatientHagzs", "EndTurn");
        }
    }
}
