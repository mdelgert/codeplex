using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Demo PhoneGap MVC";

            return View();
        }

        public ActionResult GeoLocation()
        {
            ViewBag.Message = "GEO Location";

            return View();
        }

        public ActionResult Picture()
        {
            ViewBag.Message = "Camera API";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }

}
