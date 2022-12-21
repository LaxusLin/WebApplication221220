namespace WebApplication221220.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Diaries",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        date = c.DateTime(nullable: false),
                        title = c.String(nullable: false),
                        content = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Diaries");
        }
    }
}
