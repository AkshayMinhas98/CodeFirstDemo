namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createCodeFirst_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CodeFirst_Table",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CodeFirst_Table");
        }
    }
}
