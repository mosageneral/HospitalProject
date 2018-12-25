namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class price22 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientHagzs", "MaradPriceM", c => c.Int(nullable: false));
            AddColumn("dbo.PatientHagzs", "TamenpriceT", c => c.Int(nullable: false));
            DropColumn("dbo.PatientHagzs", "MaradPrice");
            DropColumn("dbo.PatientHagzs", "Tamenprice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PatientHagzs", "Tamenprice", c => c.String(nullable: false));
            AddColumn("dbo.PatientHagzs", "MaradPrice", c => c.String(nullable: false));
            DropColumn("dbo.PatientHagzs", "TamenpriceT");
            DropColumn("dbo.PatientHagzs", "MaradPriceM");
        }
    }
}
