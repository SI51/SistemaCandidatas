using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Drawing;
using Logica.Modelo;

namespace ConsultaWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Datos = DataModelManager.CandidatoManager.getListado();
            return View();
        }
    }
}