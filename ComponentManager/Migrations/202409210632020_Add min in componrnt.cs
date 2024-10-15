namespace ComponentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addminincomponrnt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Component", "Min", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Component", "Min");
        }
    }
}
