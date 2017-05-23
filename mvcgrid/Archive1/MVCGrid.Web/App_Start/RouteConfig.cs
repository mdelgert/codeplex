using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCGrid.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //http://stackoverflow.com/questions/3337372/asp-net-mvc-removing-controller-name-from-url
            //http://stackoverflow.com/questions/1001261/how-to-remove-details-in-mvc-url-routing-but-leave-other-actions-intact

            //Removes the action word "Index" from the route
            routes.MapRoute("DynamicPage", "Page/{id}",
                    new { controller = "Page", action = "Index" }
            );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Content", action = "Index", id = UrlParameter.Optional }
            );


        }

    }

}