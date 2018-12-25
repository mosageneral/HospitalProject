namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class price : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientHagzs", "MaradPrice", c => c.String(nullable: false));
            AddColumn("dbo.PatientHagzs", "Tamenprice", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PatientHagzs", "Tamenprice");
            DropColumn("dbo.PatientHagzs", "MaradPrice");
        }
    }
}
