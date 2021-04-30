namespace FinalBackEndProjectTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FootersAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        text = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Footers");
        }
    }
}
