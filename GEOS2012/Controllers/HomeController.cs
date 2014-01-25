using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GEOS2012.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.title = "GEOS";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.title = "About";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.title = "Contact";
            return View();
        }
    }
}
