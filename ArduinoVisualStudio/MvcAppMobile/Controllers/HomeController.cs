using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Base.Core.BusinessLogic;
using Base.Core.EntityDataModel;

namespace MvcAppMobile.Controllers
{
    public class HomeController : Controller
    {
        Switch o = new Switch();
        SwitchLayer l = new SwitchLayer();

        public ActionResult Index()
        {
            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult DogDoor()
        {
            //ViewBag.Message = "Your app description page.";
            
            return View();
        }

        public ActionResult DogDoorOpen()
        {
            //ViewBag.Message = "Your app description page.";
            o.RecordID = 1;
            o.SwitchStatus = true;
            l.UpdateStatus(o);
            return View();
        }

        public ActionResult DogDoorClose()
        {
            //ViewBag.Message = "Your app description page.";
            o.RecordID = 1;
            o.SwitchStatus = false;
            l.UpdateStatus(o);
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
