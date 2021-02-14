namespace CablesConnectingDepartment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FifthMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "MobilePhone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "MobilePhone", c => c.Int(nullable: false));
        }
    }
}
