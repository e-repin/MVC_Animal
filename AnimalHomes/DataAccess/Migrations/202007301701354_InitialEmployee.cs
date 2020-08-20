namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialEmployee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Home_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Homes", t => t.Home_Id)
                .Index(t => t.Home_Id);
            
            CreateTable(
                "dbo.Homes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "Home_Id", "dbo.Homes");
            DropIndex("dbo.Animals", new[] { "Home_Id" });
            DropTable("dbo.Homes");
            DropTable("dbo.Animals");
        }
    }
}
