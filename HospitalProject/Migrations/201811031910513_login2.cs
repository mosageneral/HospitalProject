namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class login2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "User", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "User");
        }
    }
}
