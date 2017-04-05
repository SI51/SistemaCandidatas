namespace Logica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevaBaseDatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidatas",
                c => new
                    {
                        pkCandidata = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        dAnio = c.Int(nullable: false),
                        dFechaNac = c.DateTime(nullable: false, precision: 0),
                        sDescripcion = c.String(nullable: false, maxLength: 150, storeType: "nvarchar"),
                        sCorreo = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        sCurp = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        sNivel = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        sFoto = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        bStatus = c.Boolean(nullable: false),
                        iRanking = c.Int(nullable: false),
                        Municipio_pkMunicipio = c.Int(),
                        Usuarios_pkUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.pkCandidata)
                .ForeignKey("dbo.Municipios", t => t.Municipio_pkMunicipio)
                .ForeignKey("dbo.Usuarios", t => t.Usuarios_pkUsuario)
                .Index(t => t.Municipio_pkMunicipio)
                .Index(t => t.Usuarios_pkUsuario);
            
            CreateTable(
                "dbo.Municipios",
                c => new
                    {
                        pkMunicipio = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        sLogo = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        sDescripcion = c.String(nullable: false, maxLength: 150, storeType: "nvarchar"),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkMunicipio);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        pkUsuario = c.Int(nullable: false, identity: true),
                        sPassword = c.String(maxLength: 200, storeType: "nvarchar"),
                        sNombreCompleto = c.String(maxLength: 100, storeType: "nvarchar"),
                        bStatus = c.Boolean(nullable: false),
                        rol_pkRol = c.Int(),
                    })
                .PrimaryKey(t => t.pkUsuario)
                .ForeignKey("dbo.Roles", t => t.rol_pkRol)
                .Index(t => t.rol_pkRol);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        pkRol = c.Int(nullable: false, identity: true),
                        sNombre = c.String(maxLength: 200, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.pkRol);
            
            CreateTable(
                "dbo.PermisosNegados",
                c => new
                    {
                        pkPermisoNegado = c.Int(nullable: false, identity: true),
                        permiso_pkPermiso = c.Int(),
                        rol_pkRol = c.Int(),
                    })
                .PrimaryKey(t => t.pkPermisoNegado)
                .ForeignKey("dbo.Permisos", t => t.permiso_pkPermiso)
                .ForeignKey("dbo.Roles", t => t.rol_pkRol)
                .Index(t => t.permiso_pkPermiso)
                .Index(t => t.rol_pkRol);
            
            CreateTable(
                "dbo.Permisos",
                c => new
                    {
                        pkPermiso = c.Int(nullable: false, identity: true),
                        sNombre = c.String(maxLength: 200, storeType: "nvarchar"),
                        sDescripcion = c.String(maxLength: 200, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.pkPermiso);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Candidatas", "Usuarios_pkUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "rol_pkRol", "dbo.Roles");
            DropForeignKey("dbo.PermisosNegados", "rol_pkRol", "dbo.Roles");
            DropForeignKey("dbo.PermisosNegados", "permiso_pkPermiso", "dbo.Permisos");
            DropForeignKey("dbo.Candidatas", "Municipio_pkMunicipio", "dbo.Municipios");
            DropIndex("dbo.PermisosNegados", new[] { "rol_pkRol" });
            DropIndex("dbo.PermisosNegados", new[] { "permiso_pkPermiso" });
            DropIndex("dbo.Usuarios", new[] { "rol_pkRol" });
            DropIndex("dbo.Candidatas", new[] { "Usuarios_pkUsuario" });
            DropIndex("dbo.Candidatas", new[] { "Municipio_pkMunicipio" });
            DropTable("dbo.Permisos");
            DropTable("dbo.PermisosNegados");
            DropTable("dbo.Roles");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Municipios");
            DropTable("dbo.Candidatas");
        }
    }
}
