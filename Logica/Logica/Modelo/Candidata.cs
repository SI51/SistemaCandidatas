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

        [StringLength(128)]
        public string sNombre { get; set; }

        public int iAnioConvocatoria { get; set; }

        public DateTime dtFechaNacimiento { get; set; }

        [StringLength(250)]
        public string sCorreo { get; set; }

        [StringLength(100)]
        public string sCurp { get; set; }

        [StringLength(100)]
        public string sNivelEstudio { get; set; }

        [StringLength(200)]
        public string sFoto { get; set; }

        [StringLength(200)]
        public string sDescripcion { get; set; }

        public Boolean bStatus { get; set; }

        public int iRanking { get; set; }

        public virtual Municipio Municipios { get; set; }
        public virtual Usuario Usuarios { get; set; }

        public Candidata()
        {
            this.bStatus = true;
        }
    }
}
