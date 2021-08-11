namespace BarData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableRefrigerantes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Refrigerantes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sabor = c.String(),
                        Nome = c.String(),
                        Marca = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Refrigerantes");
        }
    }
}
