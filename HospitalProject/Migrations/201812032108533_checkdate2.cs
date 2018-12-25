namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class checkdate2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PatientHagzs", "CheckDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PatientHagzs", "CheckDate", c => c.DateTime(nullable: false));
        }
    }
}
