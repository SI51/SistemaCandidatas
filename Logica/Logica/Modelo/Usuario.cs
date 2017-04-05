using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logica.Modelo
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int pkUsuario { get; set; }

        [StringLength(128)]
        public String sPassword { get; set; }

        [StringLength(128)]
        public String sNombreCompleto { get; set; }

        public Boolean bStatus { get; set; }

        public virtual Rol roles { get; set; }
        
        public ICollection<Candidata> candidatas { get; set; }

        public Usuario()
        {
            this.bStatus = true;
        }
    }
}
