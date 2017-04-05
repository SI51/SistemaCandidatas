namespace Logica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CAMBIO3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Municipios", "sDescripcion", c => c.String(maxLength: 200, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Municipios", "sDescripcion", c => c.String(unicode: false));
        }
    }
}
