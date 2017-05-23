using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.ConsoleApplicationFluentNHibernate.Domain;
using Base.ConsoleApplicationFluentNHibernate.Repositories;

namespace Base.ConsoleApplicationFluentNHibernate
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTask();
            ReadTask(1);

        }


        public static void CreateTask()
        {
            Tasklist _modelTaskList = new Tasklist();
            ITasklistRepository _iTasklistRepository = new TaskListRepository();
            _modelTaskList.Taskname = "Task1";
            _modelTaskList.Tasktext = "Add CRUD code";
            _modelTaskList.Createdate = System.DateTime.Now;
            _iTasklistRepository.Add(_modelTaskList);
        }

        public static void ReadTask(int taskID)
        {
            Tasklist _modelTaskList = new Tasklist();
            ITasklistRepository _iTasklistRepository = new TaskListRepository();
            _modelTaskList.Taskid = taskID;
            _modelTaskList = _iTasklistRepository.GetById(taskID);
            Console.WriteLine(_modelTaskList.Taskname);
        }

    }
}
