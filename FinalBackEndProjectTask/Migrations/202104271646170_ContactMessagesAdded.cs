namespace FinalBackEndProjectTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactMessagesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 10),
                        text = c.String(nullable: false, maxLength: 1000),
                        Email = c.String(nullable: false),
                        Budgetlvl = c.String(nullable: false),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContactMessages");
        }
    }
}
