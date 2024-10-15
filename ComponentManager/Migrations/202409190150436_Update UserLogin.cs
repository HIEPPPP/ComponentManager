namespace ComponentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserLogin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserLogin", "DisplayName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserLogin", "DisplayName");
        }
    }
}
