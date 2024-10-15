namespace ComponentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addproprertiesamountintablecomponent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Component", "Amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Component", "Amount");
        }
    }
}
