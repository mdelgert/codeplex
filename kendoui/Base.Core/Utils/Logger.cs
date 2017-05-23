using System;
using System.Linq;
using System.Net.Http;
using Base.Core.Models;
using Base.Core.Domain;
using Base.Core.Repositories;

namespace Base.Core.Utils
{
    public class Logger
    {

        public int CreateApiLog(HttpRequestMessage request, string msg = "")
        {
            LogApi o = new LogApi();
            ILogApiRepository r = new LogApiRepositories();
            o.CreateDate = System.DateTime.Now;
            o.Message = msg + " Request=" + request.ToString();
            r.Add(o);
            return o.LogApiId;
        }

    }

}
