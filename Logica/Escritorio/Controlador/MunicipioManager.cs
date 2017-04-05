using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    return ctx.Municipios.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
