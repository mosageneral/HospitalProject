namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimeChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PatientHagzs", "Esteshara", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PatientHagzs", "Esteshara", c => c.DateTime());
        }
    }
}
