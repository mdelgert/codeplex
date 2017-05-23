using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCGrid.Core.Models;

namespace MVCGrid.Web.Controllers
{

    public class ProductController : Controller
    {

        //
        // GET: /Product/

        Core.EntitiesContext DB = new Core.EntitiesContext();

        public ActionResult HTMLEditor() //HTMLEditor
        {
            return View();
        }

        public ActionResult Tags()
        {
            return View();
        }

        public ActionResult Index()
        {

            DateTime dt1 = DateTime.Now;

            int pageIndex = 1;
            int pageSize = 5;
            string searchBy = "ProductName";
            string searchText = null;
            string orderBy = "ProductID";
            string orderDirection = "Desc";

            if (Request.QueryString["pageIndex"] != null)
            {
                Session["pageIndex"] = int.Parse(Request.QueryString["pageIndex"].ToString());
            }
            if (Session["pageIndex"] != null)
            {
                pageIndex = (int)Session["pageIndex"];
            }
            else
            {
                Session["pageIndex"] = 1; //Default value
            }

            if (Request.QueryString["pageSize"] != null)
            {
                Session["pageSize"] = int.Parse(Request.QueryString["pageSize"].ToString());
            }
            if (Session["pageSize"] != null)
            {
                pageSize = (int)Session["pageSize"];
            }
            else
            {
                Session["pageSize"] = 5; //Default value
            }

            if (Request.QueryString["searchBy"] != null)
            {
                Session["searchBy"] = Request.QueryString["searchBy"].ToString();
            }
            if (Session["searchBy"] != null)
            {
                searchBy = Session["searchBy"].ToString();
            }
            else
            {
                Session["searchBy"] = "ProductName"; //Default value
            }

            if (Request.QueryString["SearchText"] != null)
            {
                Session["SearchText"] = Request.QueryString["SearchText"].ToString();
                searchText = Request.QueryString["SearchText"].ToString();
            }
            else
            {
                Session["SearchText"] = null; //Default value
            }


            if (Request.QueryString["orderBy"] != null)
            {
                Session["orderBy"] = Request.QueryString["orderBy"].ToString();
            }
            if (Session["orderBy"] != null)
            {
                orderBy = Session["orderBy"].ToString();
            }

            if (Request.QueryString["orderDirection"] != null)
            {
                Session["orderDirection"] = Request.QueryString["orderDirection"].ToString();
            }
            if (Session["orderDirection"] != null)
            {
                orderDirection = Session["orderDirection"].ToString();
            }

            //http://stackoverflow.com/questions/781545/linq-to-sql-paging
            //http://stackoverflow.com/questions/793718/paginated-search-results-with-linq-to-sql

            //_Products.ProductID
            //descending
            //orderby _Products.ProductID descending

            //var query1 = (from _Products in DB.Products
            //              join _ProductTypes in DB.ProductTypes on _Products.ProductTypeID equals _ProductTypes.ProductTypeID into temp
            //              from _LeftJoinProductTypes in temp.DefaultIfEmpty()

            //              select new ProductModel
            //              {
            //                  ProductID = _Products.ProductID,
            //                  CreateDate = _Products.CreateDate,
            //                  ProductName = _Products.ProductName,
            //                  ProductText = _Products.ProductText,
            //                  Active = _Products.Active,
            //                  ProductTypeID = _Products.ProductTypeID,
            //                  TAGS = _Products.TAGS,
            //                  ProductTypeName = _LeftJoinProductTypes.ProductTypeName
            //              });

            var query1 = (from _Products in DB.Products
                          join _ProductTypes in DB.ProductTypes on _Products.ProductTypeID equals _ProductTypes.ProductTypeID 

                          select new ProductModel
                          {
                              ProductID = _Products.ProductID,
                              CreateDate = _Products.CreateDate,
                              ProductName = _Products.ProductName,
                              ProductText = _Products.ProductText,
                              Active = _Products.Active,
                              ProductTypeID = _Products.ProductTypeID,
                              TAGS = _Products.TAGS,
                              ProductTypeName = _ProductTypes.ProductTypeName
                          });

            //http://stackoverflow.com/questions/736952/the-best-way-to-build-dynamic-linq-query

            if (searchText != null & searchBy == "ProductName")
            {
                query1 = query1.Where(product => product.ProductName.Contains(searchText));
            }
            if (searchText != null & searchBy == "ProductText")
            {
                query1 = query1.Where(product => product.ProductText.Contains(searchText));
            }
            if (searchText != null & searchBy == "TAGS")
            {
                query1 = query1.Where(product => product.TAGS.Contains(searchText));
            }

            //Order by  //orderby _Products.ProductID descending 
            //Desc, Asc

            if (orderBy == "ProductID")
            {
                if (orderDirection == "Asc")
                {
                    query1 = query1.OrderBy(p => p.ProductID);
                }
                else
                {
                    query1 = query1.OrderByDescending(p => p.ProductID);
                }

            }

            if (orderBy == "ProductName")
            {
                if (orderDirection == "Asc")
                {
                    query1 = query1.OrderBy(p => p.ProductName);
                }
                else
                {
                    query1 = query1.OrderByDescending(p => p.ProductName);
                }
            }

            if (orderBy == "TAGS")
            {
                if (orderDirection == "Asc")
                {
                    query1 = query1.OrderBy(p => p.TAGS);
                }
                else
                {
                    query1 = query1.OrderByDescending(p => p.TAGS);
                }
            }

            //Reuse the query above
            var count = query1.Count();
            var items = query1.Skip((pageIndex - 1) * pageSize).Take(pageSize);

            //int Tpages = (int)(count / pageSize);

            //http://stackoverflow.com/questions/17944/how-to-round-up-the-result-of-integer-division
            int Tpages = (count + pageSize - 1) / pageSize;


            ViewBag.numberOfPages = Tpages;

            ViewBag.TotalRows = count;

            List<SelectListItem> listItems = new List<SelectListItem>();
            listItems.Add(new SelectListItem()
            {
                Value = "5",
                Text = "5 Rows"
            });
            listItems.Add(new SelectListItem()
            {
                Value = "10",
                Text = "10 Rows"
            });
            listItems.Add(new SelectListItem()
            {
                Value = "15",
                Text = "15 Rows"
            });

            listItems.Add(new SelectListItem()
            {
                Value = "20",
                Text = "20 Rows"
            });


            //ViewBag.RowsPerPageList = new SelectList(listItems, "Value", "Text", "3");
            ViewBag.RowsPerPageList = new SelectList(listItems, "Value", "Text", pageSize.ToString());


            List<SelectListItem> listItems2 = new List<SelectListItem>();
            listItems2.Add(new SelectListItem()
            {
                Value = "ProductName",
                Text = "Product Name"
            });
            listItems2.Add(new SelectListItem()
            {
                Value = "ProducText",
                Text = "Product Text"
            });
            listItems2.Add(new SelectListItem()
            {
                Value = "TAGS",
                Text = "TAGS"
            });

            ViewBag.searchBy = new SelectList(listItems2, "Value", "Text", searchBy);


            List<SelectListItem> listItems3 = new List<SelectListItem>();
            listItems3.Add(new SelectListItem()
            {
                Value = "ProductID",
                Text = "Product ID"
            });
            listItems3.Add(new SelectListItem()
            {
                Value = "ProductName",
                Text = "Product Name"
            });
            //listItems3.Add(new SelectListItem()
            //{
            //    Value = "ProducText",
            //    Text = "Product Text"
            //});
            listItems3.Add(new SelectListItem()
            {
                Value = "TAGS",
                Text = "TAGS"
            });

            ViewBag.orderBy = new SelectList(listItems3, "Value", "Text", orderBy);


            List<SelectListItem> listItems4 = new List<SelectListItem>();
            listItems4.Add(new SelectListItem()
            {
                Value = "Desc",
                Text = "Desc"
            });
            listItems4.Add(new SelectListItem()
            {
                Value = "Asc",
                Text = "Asc"
            });

            ViewBag.orderDirection = new SelectList(listItems4, "Value", "Text", orderDirection);

            DateTime dt2 = DateTime.Now;
            TimeSpan span = dt2 - dt1;

            ViewBag.rspTime = (int)span.TotalMilliseconds;

            return View(items);

        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.ProductTypes = new SelectList(DB.ProductTypes, "ProductTypeID", "ProductTypeName");
            ViewBag.CheckActive = false;
            return View();
        }

        //http://stackoverflow.com/questions/7614978/a-potentially-dangerous-request-form-value-was-detected-from-the-client-wresult
        //[HttpPost]
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(MVCGrid.Core.Product p)
        {
            Core.Product P = new Core.Product
            {
                ProductName = p.ProductName,
                ProductText = p.ProductText,
                TAGS = p.TAGS,
                ProductTypeID = p.ProductTypeID,
                Active = p.Active
            };

            DB.AddToProducts(P);
            DB.SaveChanges();

            //return View();
            return RedirectToRoute("Default", new { action = "Index", controller = "Product" });
        }

        public ActionResult Read(int ProductID)
        {
            ViewBag.Message = ProductID.ToString();
            MVCGrid.Core.Product c = DB.Products.Single(q => q.ProductID == ProductID);

            return View(c);
        }

        public ActionResult Update(int ProductID)
        {
            ViewBag.Message = ProductID.ToString();
            MVCGrid.Core.Product r = DB.Products.Single(q => q.ProductID == ProductID);

            //ViewBag.ProductTypes = new SelectList(DB.ProductTypes, "ProductTypeID", "ProductTypeName", r.ProductTypeID.ToString());

            //http://stackoverflow.com/questions/8260966/dropdowlist-in-asp-net-mvc-with-razor-set-selected-value-and-css-class-in-one

            ViewBag.CheckActive = r.Active;

            ViewBag.ProductTypes = new SelectList(DB.ProductTypes, "ProductTypeID", "ProductTypeName", r.ProductTypeID);

            //return View(r);

            //http://stackoverflow.com/questions/18757/using-asp-net-mvc-how-to-best-avoid-writing-both-the-add-view-and-edit-view
            //share the same view for create and edit

            return View("Create", r);
        }

        //[HttpPost]
        [HttpPost, ValidateInput(false)]
        public ActionResult Update(MVCGrid.Core.Product p)
        {
            MVCGrid.Core.Product r = DB.Products.Where(q => q.ProductID == p.ProductID).Single();
            r.ProductName = p.ProductName;
            r.ProductText = p.ProductText;
            r.TAGS = p.TAGS;
            r.ProductTypeID = p.ProductTypeID;
            r.Active = p.Active;
            DB.SaveChanges();
            //return View();
            return RedirectToRoute("Default", new { action = "Index", controller = "Product" });
        }

        public ActionResult Delete(int ProductID)
        {
            //ViewBag.Message = ProductID.ToString();
            MVCGrid.Core.Product r = DB.Products.Single(q => q.ProductID == ProductID);
            DB.DeleteObject(r);
            DB.SaveChanges();
            //return View();
            return RedirectToRoute("Default", new { action = "Index", controller = "Product" });
        }

    }

}




//var query = from c in DB.Products
//            orderby c.ProductID descending
//            select c;

//return View(query.ToList());

//ViewBag.ProductTypes = new SelectList(DB.ProductTypes, "ProductTypeID", "ProductTypeName");



//This is right join only
//var query = from _Products in DB.Products
//            join _ProductTypes in DB.ProductTypes on _Products.ProductTypeID equals _ProductTypes.ProductTypeID
//            orderby _Products.ProductID descending
//            select new ProductModel //http://stack247.wordpress.com/2011/03/21/use-viewmodel-model-binder-in-linq-to-entity-framework-linq-doesnt-return-all-joined-data/
//            {
//                ProductID = _Products.ProductID,
//                CreateDate = _Products.CreateDate,
//                ProductName = _Products.ProductName,
//                ProductText = _Products.ProductText,
//                Active = _Products.Active,
//                ProductTypeID = _Products.ProductTypeID,
//                ProductTypeName = _ProductTypes.ProductTypeName
//            };

////This is with a left join http://solidcoding.blogspot.com/2007/12/left-outer-join-in-linq.html
//var query = from _Products in DB.Products
//            join _ProductTypes in DB.ProductTypes on _Products.ProductTypeID equals _ProductTypes.ProductTypeID into temp
//            from _LeftJoinProductTypes in temp.DefaultIfEmpty()
//            orderby _Products.ProductID descending

//            select new ProductModel //http://stack247.wordpress.com/2011/03/21/use-viewmodel-model-binder-in-linq-to-entity-framework-linq-doesnt-return-all-joined-data/
//            {
//                ProductID = _Products.ProductID,
//                CreateDate = _Products.CreateDate,
//                ProductName = _Products.ProductName,
//                ProductText = _Products.ProductText,
//                Active = _Products.Active,
//                ProductTypeID = _Products.ProductTypeID,
//                ProductTypeName = _LeftJoinProductTypes.ProductTypeName
//            };
