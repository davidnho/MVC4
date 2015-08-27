using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "This is the main home page - Noel.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is the About view";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
