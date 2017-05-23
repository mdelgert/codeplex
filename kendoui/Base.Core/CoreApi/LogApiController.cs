using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NHibernate;
using NHibernate.Linq;
using Base.Core.Models;
using Base.Core.Domain;
using Base.Core.Repositories;
using Base.Core.Utils;
using Base.Core.Utils.Nhibernate;

namespace Base.Core.CoreApi
{

    public class LogApiController : ApiController
    {

        public IEnumerable<LogApi> Get()
        {
            using (ISession session = SessionSetup.OpenSessionNhibernate())
            {
                return session.Query<LogApi>()
                    .Select(p => new LogApi
                    {
                        LogApiId = p.LogApiId,
                        CreateDate = p.CreateDate,
                        Message = p.Message
                    }).ToList<LogApi>();
            }
        }

        public LogApi Get(int keyId)
        {
            ILogApiRepository r = new LogApiRepositories();
            return r.GetById(keyId);
        }

    }

}

