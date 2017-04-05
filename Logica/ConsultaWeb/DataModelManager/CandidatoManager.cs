using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Logica.Modelo;

namespace ConsultaWeb.DataModelManager
{
    public class CandidatoManager
    {
        public static List<Candidata> getListado()
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Candidatas.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}