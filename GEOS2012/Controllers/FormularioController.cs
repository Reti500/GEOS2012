using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GEOS2012.Controllers
{
    public class FormularioController : Controller
    {
        //
        // GET: /Formulario/

        public ActionResult Index()
        {
            ViewBag.title = "Formulario";

            return View();
        }

        public ActionResult Exito(string palabra)
        {
            ViewBag.title = "Exito!!";
            ViewBag.palabra = palabra;

            return View();
        }

    }
}
