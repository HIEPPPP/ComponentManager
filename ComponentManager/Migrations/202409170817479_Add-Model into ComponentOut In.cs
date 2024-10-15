namespace ComponentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModelintoComponentOutIn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ComponentIn", "Model", c => c.String());
            AddColumn("dbo.ComponentOut", "Model", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ComponentOut", "Model");
            DropColumn("dbo.ComponentIn", "Model");
        }
    }
}
