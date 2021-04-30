namespace FinalBackEndProjectTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aboutmetaadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutMetas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Procent = c.Int(nullable: false),
                        Diagramme = c.String(),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AboutMetas");
        }
    }
}
