using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//http://www.iwantmymvc.com/2011-03-20-dynamic-content-templates-using-razor
//http://www.kindblad.com/2011/04/search-engine-friendly-urls-in-aspnet.html
//http://www.iansuttle.com/blog/post/ASPNET-MVC-Store-Routes-in-the-Database.aspx
//http://www.kindblad.com/2011/04/search-engine-friendly-urls-in-aspnet.html

namespace MVCGrid.Web.Controllers
{
    public class PageController : Controller
    {
        //
        // GET: /Page/

        public ActionResult Index()
        {
            string pageName = null;

            if (pageName == null)
            {
                string[] file = Request.CurrentExecutionFilePath.Split('/');
                pageName = file[file.Length - 1];
            }

            if (pageName == "Page-One")
            {
                ViewBag.Message = "Page-One";
            }

            if (pageName == "Page-Two")
            {
                ViewBag.Message = "Page-Two";
            }

            return View();
        }

    }

}
