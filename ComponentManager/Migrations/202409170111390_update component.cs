namespace ComponentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecomponent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Component", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Component", "Quantity");
        }
    }
}
