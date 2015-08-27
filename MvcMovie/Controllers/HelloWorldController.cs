using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name="Noel", int numTimes = 5)
        {

            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }

    }
}



//// OLD CODES

////
//// GET: /HelloWorld/

//public string Index()
//{
//    return "This is the default action";
//}

//////These examples directly returns HTML codes to the page 
//public string Welcome(string name, int numTimes = 5)
//{
//    ////These examples directly returns HTML codes to the page 
//    //return "<b>Welcome Noel!";
//    return HttpUtility.HtmlEncode("Mabuhay" + name + " numTimes = " + numTimes);
//}
