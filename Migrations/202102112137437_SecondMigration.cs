namespace CablesConnectingDepartment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cables", "PricePerMeter", c => c.Int(nullable: false));
            DropColumn("dbo.Cables", "PricePerHour");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cables", "PricePerHour", c => c.Int(nullable: false));
            DropColumn("dbo.Cables", "PricePerMeter");
        }
    }
}
