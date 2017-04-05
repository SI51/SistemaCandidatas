using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.Entity;
using Logica.Modelo;
using Escritorio.Controlador;

namespace Escritorio.Controlador
{
    class MunicipioManager
    {
        public static List<Municipio> ListarTodo()
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Municipios.Where(r => r.bStatus == true).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
