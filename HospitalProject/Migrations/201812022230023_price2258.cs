namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class price2258 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Marads", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.Tamen", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tamen", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Marads", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
