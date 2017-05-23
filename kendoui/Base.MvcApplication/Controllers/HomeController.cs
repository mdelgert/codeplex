using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Base.MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult GetViewByName(string viewFolder, string viewName)
        {
            string viewPath = "~/Views/" + viewFolder + "/" + viewName;
            return View(viewPath);
        }

        public ActionResult Index()
        {
            //ViewBag.Message = "Kendo UI MVC demo application.";
            return View();
        }
        public ActionResult Sitemap()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Links()
        {
            return View();
        }
        public ActionResult TestWebApi()
        {
            return View();
        }

    }

}
