using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Base.Core.Utils;

namespace Base.Core.CoreApi
{
    public class UserController : ApiController
    {
        readonly Logger l = new Logger();

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

    }

}


