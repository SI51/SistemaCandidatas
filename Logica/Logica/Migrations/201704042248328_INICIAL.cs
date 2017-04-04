namespace Logica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INICIAL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidatas",
                c => new
                    {
                        pkCandidata = c.Int(nullable: false, identity: true),
                        sNombre = c.String(maxLength: 128),
                        iAnioConvocatoria = c.Int(nullable: false),
                        dtFechaNacimiento = c.DateTime(nullable: false),
                        sCorreo = c.String(maxLength: 250),
                        sCurp = c.String(maxLength: 100),
                        sNivelEstudio = c.String(maxLength: 100),
                        sFoto = c.String(maxLength: 200),
                        sDescripcion = c.String(maxLength: 4000),
                        bStatus = c.Boolean(nullable: false),
                        iRanking = c.Int(nullable: false),
                        Municipios_pkMunicipio = c.Int(),
                        Usuarios_pkUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.pkCandidata)
                .ForeignKey("dbo.Municipios", t => t.Municipios_pkMunicipio)
                .ForeignKey("dbo.Usuarios", t => t.Usuarios_pkUsuario)
                .Index(t => t.Municipios_pkMunicipio)
                .Index(t => t.Usuarios_pkUsuario);
            
            CreateTable(
                "dbo.Municipios",
                c => new
                    {
                        pkMunicipio = c.Int(nullable: false, identity: true),
                        sMunicipio = c.String(maxLength: 128),
                        sLogo = c.String(maxLength: 128),
                        sDescripcion = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.pkMunicipio);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        pkUsuario = c.Int(nullable: false, identity: true),
                        sUsuario = c.String(maxLength: 128),
                        sPassword = c.String(maxLength: 128),
                        sNombre = c.String(maxLength: 128),
                        sApellidos = c.String(maxLength: 128),
                        bStatus = c.Boolean(nullable: false),
                        roles_pkRol = c.Int(),
                    })
                .PrimaryKey(t => t.pkUsuario)
                .ForeignKey("dbo.Roles", t => t.roles_pkRol)
                .Index(t => t.roles_pkRol);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        pkRol = c.Int(nullable: false, identity: true),
                        sRol = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.pkRol);
            
            CreateTable(
                "dbo.PermisosNegados",
                c => new
                    {
                        pkPermisoNegado = c.Int(nullable: false, identity: true),
                        bStatus = c.Boolean(nullable: false),
                        permisos_pkPermiso = c.Int(),
                        roles_pkRol = c.Int(),
                    })
                .PrimaryKey(t => t.pkPermisoNegado)
                .ForeignKey("dbo.Permisos", t => t.permisos_pkPermiso)
                .ForeignKey("dbo.Roles", t => t.roles_pkRol)
                .Index(t => t.permisos_pkPermiso)
                .Index(t => t.roles_pkRol);
            
            CreateTable(
                "dbo.Permisos",
                c => new
                    {
                        pkPermiso = c.Int(nullable: false, identity: true),
                        sPermiso = c.String(maxLength: 128),
                        sDescripcion = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.pkPermiso);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Candidatas", "Usuarios_pkUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "roles_pkRol", "dbo.Roles");
            DropForeignKey("dbo.PermisosNegados", "roles_pkRol", "dbo.Roles");
            DropForeignKey("dbo.PermisosNegados", "permisos_pkPermiso", "dbo.Permisos");
            DropForeignKey("dbo.Candidatas", "Municipios_pkMunicipio", "dbo.Municipios");
            DropIndex("dbo.PermisosNegados", new[] { "roles_pkRol" });
            DropIndex("dbo.PermisosNegados", new[] { "permisos_pkPermiso" });
            DropIndex("dbo.Usuarios", new[] { "roles_pkRol" });
            DropIndex("dbo.Candidatas", new[] { "Usuarios_pkUsuario" });
            DropIndex("dbo.Candidatas", new[] { "Municipios_pkMunicipio" });
            DropTable("dbo.Permisos");
            DropTable("dbo.PermisosNegados");
            DropTable("dbo.Roles");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Municipios");
            DropTable("dbo.Candidatas");
        }
    }
}
