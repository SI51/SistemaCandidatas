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

        [StringLength(200)]
        public String sPassword { get; set; }

        [StringLength(100)]
        public String sNombreCompleto { get; set; }
        
        public Boolean bStatus { get; set; }

        public virtual Rol rol { get; set; }

        public Usuario()
        {
            this.bStatus = true;
        }
    }
}