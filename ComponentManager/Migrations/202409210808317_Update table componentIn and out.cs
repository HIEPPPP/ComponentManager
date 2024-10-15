namespace ComponentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatetablecomponentInandout : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ComponentIn", "Amount", c => c.Int(nullable: false));
            AddColumn("dbo.ComponentOut", "Amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ComponentOut", "Amount");
            DropColumn("dbo.ComponentIn", "Amount");
        }
    }
}
