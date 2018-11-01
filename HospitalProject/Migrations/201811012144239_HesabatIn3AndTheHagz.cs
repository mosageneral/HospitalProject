namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HesabatIn3AndTheHagz : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientHagzs", "TamenMoney", c => c.Int(nullable: false));
            AddColumn("dbo.PatientHagzs", "BaidMoney", c => c.Int(nullable: false));
            AddColumn("dbo.PatientHagzs", "AllMoney", c => c.Int(nullable: false));
            AlterColumn("dbo.HesabatIns", "EntryMoney", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HesabatIns", "EntryMoney", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.PatientHagzs", "AllMoney");
            DropColumn("dbo.PatientHagzs", "BaidMoney");
            DropColumn("dbo.PatientHagzs", "TamenMoney");
        }
    }
}
