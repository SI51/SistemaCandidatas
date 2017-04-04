using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logica.Modelo
{
    [Table("PermisosNegados")]
    public class PermisoNegado
    {
        [Key]
        public int pkPermisoNegado { get; set; }

        public Boolean bStatus { get; set; }

        public virtual Rol roles { get; set; }
        public virtual Permiso permisos { get; set; }

        public PermisoNegado()
        {
            this.bStatus = true;
        }
    }
}
