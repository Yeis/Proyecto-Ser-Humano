namespace SerHumano.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reporte", "Titulo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reporte", "Titulo");
        }
    }
}
