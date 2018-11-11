namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adwyaa : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Adwyas", "Content1");
            DropColumn("dbo.Adwyas", "Content2");
            DropColumn("dbo.Adwyas", "Content3");
            DropColumn("dbo.Adwyas", "Content4");
            DropColumn("dbo.Adwyas", "Content5");
            DropColumn("dbo.Adwyas", "Content6");
            DropColumn("dbo.Adwyas", "Content7");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Adwyas", "Content7", c => c.String());
            AddColumn("dbo.Adwyas", "Content6", c => c.String());
            AddColumn("dbo.Adwyas", "Content5", c => c.String());
            AddColumn("dbo.Adwyas", "Content4", c => c.String());
            AddColumn("dbo.Adwyas", "Content3", c => c.String());
            AddColumn("dbo.Adwyas", "Content2", c => c.String());
            AddColumn("dbo.Adwyas", "Content1", c => c.String());
        }
    }
}
