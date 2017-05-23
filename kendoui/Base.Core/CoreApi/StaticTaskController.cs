using Base.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Base.Core.CoreApi
{
    public class StaticTaskController : ApiController
    {

        readonly TaskItem[] tasks = new TaskItem[]  
        {
            new TaskItem {KeyId = 1, TaskName = "Create KendoUI HTML demo page."},
            new TaskItem {KeyId = 2, TaskName = "Create a grid only using javascript."},
            new TaskItem {KeyId = 3, TaskName = "Create a grid using Api Controller."}
        };

        public IEnumerable<TaskItem> GetStaticTasks()
        {
            return tasks;
        }

    }

}
