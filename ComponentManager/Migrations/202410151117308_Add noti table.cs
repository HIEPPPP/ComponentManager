namespace ComponentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addnotitable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        NotiType = c.String(),
                        Quantity = c.Int(nullable: false),
                        IsHandled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Notis");
        }
    }
}
