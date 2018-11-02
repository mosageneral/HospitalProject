namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HesabatIn3AndTheHagz5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PatientHagzs", "Esteshara");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PatientHagzs", "Esteshara", c => c.DateTime(nullable: false));
        }
    }
}
