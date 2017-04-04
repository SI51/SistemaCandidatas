using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Logica.Modelo
{
    public class DataModel : DbContext
    {
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<PermisoNegado> PermisosNegados { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Candidata> Candidatas { get; set; }
        public DbSet<Municipio> Municipios { get; set; }

        protected override void OnModelCreating(DbModelBuilder ModelBuilder)
        {
            base.OnModelCreating(ModelBuilder);
        }

        public DataModel() : base("DataModel") { }
    }
}
