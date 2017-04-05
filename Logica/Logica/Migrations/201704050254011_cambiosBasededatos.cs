namespace Logica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiosBasededatos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Candidatas", "sDescripcion", c => c.String(maxLength: 200, storeType: "nvarchar"));
            AlterColumn("dbo.Permisos", "sDescripcion", c => c.String(maxLength: 128, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Permisos", "sDescripcion", c => c.String(unicode: false));
            AlterColumn("dbo.Candidatas", "sDescripcion", c => c.String(unicode: false));
        }
    }
}
