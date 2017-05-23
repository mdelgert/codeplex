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

//http://www.asp.net/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api
    
//http://www.codeproject.com/Articles/659131/Understanding-and-Implementing-ASPNET-WebAPI

//Now the basic CRUD operations are mapped to the HTTP protocols in the following manner: 
//GET: This maps to the R(Retrieve) part of the CRUD operation. This will be used to retrieve the required data (representation of data) from the remote resource.
//PUT: This maps to the U(Update) part of the CRUD operation. This protocol will update the current representation of the data on the remote server.
//POST: This maps to the C(Create) part of the CRUD operation. This will create a new entry for the current data that is being sent to the server.
//DELETE: This maps to the D(Delete) part of the CRUD operation. This will delete the specified data from the remote server. 
    
    public class TaskItemController : ApiController
    {
        readonly Logger l = new Logger();

        public IEnumerable<TaskItem> Get()
        {
            using (ISession session = SessionSetup.OpenSessionNhibernate())
            {
                return session.Query<TaskItem>()
                    .Select(p => new TaskItem
                    {
                        KeyId = p.KeyId,
                        CreateDate = p.CreateDate,
                        TaskName = p.TaskName
                    }).ToList<TaskItem>();
            }
        }

        public TaskItem Get(int taskId)
        {
            ITaskItemRepository r = new TaskItemRepositories();
            return r.GetById(taskId);
           
        }

        public HttpResponseMessage Create(string taskName)
        {
            TaskItem o = new TaskItem();
            ITaskItemRepository r = new TaskItemRepositories();
            o.CreateDate = System.DateTime.Now;
            o.TaskName = taskName;
            r.Add(o);

            string msg = "Base.Core.CoreApi.TaskController";
            var logApiId = l.CreateApiLog(Request, msg);
            string content = "Create method response: TaskName=" + o.TaskName + " TaskID=" + o.KeyId.ToString() + " " + msg + " LogApiId =" + logApiId.ToString();

            return new HttpResponseMessage()
            {
                Content = new StringContent(content)
            };

        }

        // DELETE api/<controller>/5
        //[HttpDelete]

        public HttpResponseMessage Delete(int KeyId)
        {
            string msg = "Base.Core.CoreApi.TaskController Delete KeyId=" + KeyId.ToString();
            l.CreateApiLog(Request, msg);

            TaskItem o = new TaskItem();
            ITaskItemRepository r = new TaskItemRepositories();
            o = r.GetById(KeyId);
            r.Delete(o);
            return Request.CreateResponse(HttpStatusCode.OK);
    
        }

    }

}
