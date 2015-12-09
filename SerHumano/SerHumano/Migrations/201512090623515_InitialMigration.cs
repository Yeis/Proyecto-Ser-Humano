namespace SerHumano.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reporte",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ubicacion = c.String(),
                        CausaReporte = c.String(),
                        FechaReporte = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reporte");
        }
    }
}
