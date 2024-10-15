namespace ComponentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletecloumnquantityincomponent : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Component", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Component", "Quantity", c => c.Int(nullable: false));
        }
    }
}
