using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.ConsoleEntityTest.EntityDataModel;

namespace Base.ConsoleEntityTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("BEGIN2:");

            TaskList _modelTaskList = new TaskList();

            using (var context = new DBEntities())
            {
                _modelTaskList.TaskName = "task1";
                _modelTaskList.TaskText = "taskText1";
                _modelTaskList.CreateDate = System.DateTime.Now;
                context.TaskLists.Add(_modelTaskList);
                context.SaveChanges();
            }

            using (var context = new DBEntities())
            {
                _modelTaskList = context.TaskLists.Find(1);
                Console.WriteLine(_modelTaskList.TaskName);
            }

            Console.WriteLine("END2:");
            Console.ReadKey();

        }

    }

}
