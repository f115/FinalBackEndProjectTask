namespace FinalBackEndProjectTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.comments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        password = c.Int(nullable: false),
                        full_name = c.String(),
                        surname = c.String(),
                        budgetlvl = c.String(),
                        message = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.comments");
        }
    }
}
