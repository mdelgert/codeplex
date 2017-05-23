using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;

namespace Base.Core.CoreApi
{
    public class CodeViewController : ApiController
    {

        public HttpResponseMessage Get(string controller)
        {

            var controllerPath = HttpContext.Current.Server.MapPath("~/Controllers/" + controller + "Controller.cs");

            var controllerSource = "";

            if (System.IO.File.Exists(controllerPath))
            {
                controllerSource = System.IO.File.ReadAllText(controllerPath).ToString();
            }

            return new HttpResponseMessage()
            {
                Content = new StringContent(controllerSource)
            };

        }

    }

}

