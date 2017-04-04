namespace Logica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CAMBIOS : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "sNombreCompleto", c => c.String(maxLength: 128, storeType: "nvarchar"));
            AlterColumn("dbo.Candidatas", "dtFechaNacimiento", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.Candidatas", "sDescripcion", c => c.String(unicode: false));
            AlterColumn("dbo.Municipios", "sDescripcion", c => c.String(unicode: false));
            AlterColumn("dbo.Permisos", "sDescripcion", c => c.String(unicode: false));
            DropColumn("dbo.Usuarios", "sUsuario");
            DropColumn("dbo.Usuarios", "sNombre");
            DropColumn("dbo.Usuarios", "sApellidos");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "sApellidos", c => c.String(maxLength: 128));
            AddColumn("dbo.Usuarios", "sNombre", c => c.String(maxLength: 128));
            AddColumn("dbo.Usuarios", "sUsuario", c => c.String(maxLength: 128));
            AlterColumn("dbo.Permisos", "sDescripcion", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Municipios", "sDescripcion", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Candidatas", "sDescripcion", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Candidatas", "dtFechaNacimiento", c => c.DateTime(nullable: false));
            DropColumn("dbo.Usuarios", "sNombreCompleto");
        }
    }
}
