namespace CablesConnectingDepartment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "CostPerHour", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "CostPerHour", c => c.Int(nullable: false));
        }
    }
}
