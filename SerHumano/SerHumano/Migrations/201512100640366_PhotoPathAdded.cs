namespace SerHumano.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhotoPathAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reporte", "FilePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reporte", "FilePath");
        }
    }
}
