﻿using System;
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

        [StringLength(50)]
        [Required(ErrorMessage = "Campo requerido")]
        public string sNombre { get; set; }

        [StringLength(128)]
        [Required(ErrorMessage = "Campo requerido")]
        public string sLogo { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "Campo requerido")]
        public String sDescripcion { get; set; }

        public Boolean bStatus { get; set; }

        public ICollection<Candidata> candidatas { get; set; }

        public Municipio()
        {
            this.bStatus = true;
        }
    }
}
