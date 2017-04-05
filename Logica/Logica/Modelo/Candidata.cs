using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logica.Modelo
{
    [Table("Candidatas")]
    public class Candidata
    {
        [Key]

        public int pkCandidata { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Campo requerido")]
        public string sNombre { get; set; }

        public int dAnio { get; set; }

        public DateTime dFechaNac { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "Campo requerido")]
        public string sDescripcion { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Campo requerido")]
        public string sCorreo { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Campo requerido")]
        public string sCurp { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Campo requerido")]
        public string sNivel { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Campo requerido")]
        public string sFoto { get; set; }

        public Boolean bStatus { get; set; }

        public int iRanking { get; set; }

        public virtual Municipio Municipio { get; set; }
        public virtual Usuario Usuarios { get; set; }

        public Candidata()
        {
            this.bStatus = true;
        }
    }
}
