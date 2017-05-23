//Enabling Cross-Origin Requests in ASP.NET Web API - http://www.asp.net/web-api/overview/security/enabling-cross-origin-requests-in-web-api
//An Introduction to ASP.NET Web API - http://www.codemag.com/Article/1206081
//Self Hosted Web API Wrapper Class - http://www.codeproject.com/Tips/649042/Self-Hosted-Web-API-Wrapper-Class
//Using Kendo UI Grid with Web API Controller in ASP.Net Web Form - http://www.studyoverflow.org/2013/07/using-kendo-ui-grid-with-web-api.html
//Reading server file with javascript - http://stackoverflow.com/questions/13329853/reading-server-file-with-javascript

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Base.Core.Utils;

namespace Base.Core.CoreApi
{
    public class TestsController : ApiController
    {
        readonly Logger l = new Logger();

        public HttpResponseMessage Get()
        {
            string msg = "Base.Core.CoreApi.TestsController.Get()";
            var logApiId = l.CreateApiLog(Request, msg);
            string content = msg + " LogApiId =" + logApiId.ToString();

            return new HttpResponseMessage()
            {
                Content = new StringContent(content)
            };
        }

        public HttpResponseMessage Post()
        {
            string msg = "Base.Core.CoreApi.TestsController.Post()";
            var logApiId = l.CreateApiLog(Request, msg);
            string content = msg + " LogApiId =" + logApiId.ToString();

            return new HttpResponseMessage()
            {
                Content = new StringContent(content)
            };
        }

        public HttpResponseMessage Put()
        {
            string msg = "Base.Core.CoreApi.TestsController.Put()";
            var logApiId = l.CreateApiLog(Request, msg);
            string content = msg + " LogApiId =" + logApiId.ToString();

            return new HttpResponseMessage()
            {
                Content = new StringContent(content)
            };
        }

    }

}