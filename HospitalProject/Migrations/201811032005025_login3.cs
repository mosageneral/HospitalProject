namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class login3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "User");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "User", c => c.String());
        }
    }
}
