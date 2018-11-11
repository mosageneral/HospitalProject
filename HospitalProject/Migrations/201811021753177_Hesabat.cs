namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Hesabat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HesabatIns", "DateOfpay", c => c.DateTime(nullable: false));
            AddColumn("dbo.HesabatIns", "PayType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HesabatIns", "PayType");
            DropColumn("dbo.HesabatIns", "DateOfpay");
        }
    }
}
