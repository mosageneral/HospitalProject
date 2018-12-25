namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mosa : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PatientHagzs");
            AlterColumn("dbo.PatientHagzs", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.PatientHagzs", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.PatientHagzs", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.PatientHagzs");
            AlterColumn("dbo.PatientHagzs", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.PatientHagzs", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.PatientHagzs", "Name");
        }
    }
}
