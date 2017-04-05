using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logica.Modelo
{
    [Table("Municipios")]
    public class Municipio
    {
        [Key]
        public int pkMunicipio { get; set; }

        [StringLength(128)]
        public string sMunicipio { get; set; }

        [StringLength(128)]
        public string sLogo { get; set; }

        public string sDescripcion { get; set; }

        public Boolean bStatus { get; set; }

        public ICollection<Candidata> Candidatas { get; set; }

        public Municipio()
        {
            this.bStatus = true;
        }
    }
}
