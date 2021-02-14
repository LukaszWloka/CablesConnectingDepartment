namespace CablesConnectingDepartment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConnectionTable",
                c => new
                    {
                        CableNumber = c.Int(nullable: false, identity: true),
                        CableTypeId = c.Int(nullable: false),
                        Lenght = c.Int(nullable: false),
                        ResponsiblePersonId = c.Int(nullable: false),
                        ConnectionDescription = c.String(),
                        PriorityMarker = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CableNumber);
            
            CreateTable(
                "dbo.Cables",
                c => new
                    {
                        CableId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        PricePerHour = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CableId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        PersonalId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        SecondName = c.String(),
                        MobilePhone = c.Int(nullable: false),
                        CostPerHour = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonalId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
            DropTable("dbo.Cables");
            DropTable("dbo.ConnectionTable");
        }
    }
}
