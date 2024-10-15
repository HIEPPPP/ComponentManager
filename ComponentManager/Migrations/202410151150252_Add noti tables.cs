namespace ComponentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addnotitables : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Notis", newName: "Noti");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Noti", newName: "Notis");
        }
    }
}
