using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MVCGrid.Buisness;
using MVCGrid.DAL;

//S0012: The type 'System.Data.Objects.DataClasses.EntityObject' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Data.Entity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'.
//http://www.projectenvision.com/blog/4/CS0012-The-type-System-Data-Objects-DataClasses-EntityObject-is-defined-in-an-assembly-that-is-not-referenced

namespace MVCGrid.Web.Controllers
{
    public class ContentController : Controller
    {
        EntitiesContext MVCGridDB = new EntitiesContext();

        //
        // GET: /Context/

        //ToDo: put all DB requests in Buisness logic layer

        public ActionResult Index()
        {
            var query = from c in MVCGridDB.Contents 
                        orderby c.ContentID descending
                        select c;
            return View(query.ToList());
        }

        public ViewResult Details(int ContentID)
        {
            MVCGrid.DAL.Content c = MVCGridDB.Contents.Single(q => q.ContentID == ContentID);
            return View(c);
        }

        public ViewResult Edit(int ContentID)
        {
            MVCGrid.DAL.Content c = MVCGridDB.Contents.Single(q => q.ContentID == ContentID);
            return View(c);
        }

        [HttpPost]
        public ActionResult Edit(MVCGrid.DAL.Content c)
        {
            MVCGrid.DAL.Content r = MVCGridDB.Contents.Where(q => q.ContentID == c.ContentID).Single();
            r.PageName = c.PageName;
            r.ContentText = c.ContentText;
            MVCGridDB.SaveChanges();
            return View(c);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MVCGrid.DAL.Content c)
        {
            MVCGrid.Buisness.Content r = new MVCGrid.Buisness.Content();
            r.Create(c.PageName, c.ContentText);
            //return View(c);
            //http://stackoverflow.com/questions/12070927/redirecttoroute-and-routing
            return RedirectToRoute("Default", new { action = "Index", controller = "Content" });
        }

        public ActionResult Delete(int ContentID)
        {
            MVCGrid.DAL.Content c = MVCGridDB.Contents.Single(q => q.ContentID == ContentID);
            MVCGridDB.DeleteObject(c);
            MVCGridDB.SaveChanges();
            return RedirectToRoute("Default", new { action = "Index", controller = "Content" });
        }

    }

}
