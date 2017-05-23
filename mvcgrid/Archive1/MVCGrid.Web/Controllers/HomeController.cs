using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCGrid.Buisness;

namespace MVCGrid.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to kick-start your ASP.NET MVC application.";
            Content c = new Content();
            c.Create("TEST", "TEST");
            ViewBag.Message = "MVC Grid First Test";
            return View();
        }

    }
}
