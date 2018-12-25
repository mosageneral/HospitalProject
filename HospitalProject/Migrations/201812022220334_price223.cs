namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class price223 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PatientHagzs", "TamenMoney");
            DropColumn("dbo.PatientHagzs", "BaidMoney");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PatientHagzs", "BaidMoney", c => c.Int(nullable: false));
            AddColumn("dbo.PatientHagzs", "TamenMoney", c => c.Int(nullable: false));
        }
    }
}
