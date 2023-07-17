namespace PlantsWpfApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlantImage = c.String(),
                        PlantLocation = c.String(),
                        BedProp = c.String(),
                        GoodProp = c.String(),
                        Description = c.String(),
                        ScienceName = c.String(),
                        PopName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Plants");
        }
    }
}
