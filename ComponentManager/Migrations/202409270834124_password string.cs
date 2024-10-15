namespace ComponentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class passwordstring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserLogin", "Password", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserLogin", "Password", c => c.Int(nullable: false));
        }
    }
}
