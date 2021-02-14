namespace CablesConnectingDepartment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForthMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "LastName", c => c.String());
            DropColumn("dbo.Employees", "SecondName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "SecondName", c => c.String());
            DropColumn("dbo.Employees", "LastName");
        }
    }
}
