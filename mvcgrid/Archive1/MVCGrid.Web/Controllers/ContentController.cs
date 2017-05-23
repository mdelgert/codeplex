//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web.Mvc;
//using MVCGrid.DAL;

////S0012: The type 'System.Data.Objects.DataClasses.EntityObject' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Data.Entity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'.
////http://www.projectenvision.com/blog/4/CS0012-The-type-System-Data-Objects-DataClasses-EntityObject-is-defined-in-an-assembly-that-is-not-referenced

//namespace MVCGrid.Web.Controllers
//{
//    public class ContentController : Controller
//    {
//        EntitiesContext MVCGridDB = new EntitiesContext();

//        //
//        // GET: /Context/

//        //ToDo: put all DB requests in Buisness logic layer

//        public ActionResult Index()
//        {
//            var query = from c in MVCGridDB.Contents select c;
//            return View(query.ToList());
//        }

//        public ViewResult Details(int ContentID)
//        {
//            Content c = MVCGridDB.Contents.Single(q => q.ContentID == ContentID);
//            return View(c);
//        }

//        public ViewResult Edit(int ContentID)
//        {
//            Content c = MVCGridDB.Contents.Single(q => q.ContentID == ContentID);
//            return View(c);
//        }

//        [HttpPost]
//        public ActionResult Edit(Content c)
//        {
//            Content r = MVCGridDB.Contents.Where(q => q.ContentID == c.ContentID).Single();
//            r.PageName = c.PageName;
//            r.ContentText = c.ContentText;
//            MVCGridDB.SaveChanges();
//            return View(c);
//        }

//    }

//}
