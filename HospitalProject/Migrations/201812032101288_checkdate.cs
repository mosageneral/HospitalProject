namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class checkdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientHagzs", "CheckDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PatientHagzs", "CheckDate");
        }
    }
}
