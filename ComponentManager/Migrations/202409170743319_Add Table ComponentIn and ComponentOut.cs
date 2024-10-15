namespace ComponentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableComponentInandComponentOut : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ComponentIn",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        NgayNhap = c.DateTime(nullable: false),
                        Provider = c.String(),
                        Price = c.Double(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ComponentOut",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        UsageDate = c.DateTime(nullable: false),
                        Reason = c.String(),
                        RequestBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ComponentOut");
            DropTable("dbo.ComponentIn");
        }
    }
}
