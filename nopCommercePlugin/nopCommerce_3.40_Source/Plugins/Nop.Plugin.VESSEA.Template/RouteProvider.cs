//Steps to add a new custom page in nopCommerce 3.1 (MVC Version)
//http://www.strivingprogrammers.com/Blog/post/Lavish-Kumar/20/Steps-to-add-a-new-custom-page-in-nopCommerce-3-1-MVC-Version/


using System.Web.Mvc;
using System.Web.Routing;
using Nop.Web.Framework.Mvc.Routes;

//http://docs.nopcommerce.com/display/nc/How+to+write+a+nopCommerce+plugin -- Section routes

namespace Nop.Plugin.VESSEA.Template
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            //Documentation
            routes.MapRoute("Plugin.VESSEA.Template.Notes",
                 "Plugins/VESSEATemplate/Notes",
                 new { controller = "VESSEATemplate", action = "Notes" },
                 new[] { "Nop.Plugin.VESSEA.Template.Controllers" }
            );

            //License
            routes.MapRoute("Plugin.VESSEA.Template.License",
                 "Plugins/VESSEATemplate/License",
                 new { controller = "VESSEATemplate", action = "License" },
                 new[] { "Nop.Plugin.VESSEA.Template.Controllers" }
            );

        }
        public int Priority
        {
            get
            {
                return 0;
            }
        }

    }

}
