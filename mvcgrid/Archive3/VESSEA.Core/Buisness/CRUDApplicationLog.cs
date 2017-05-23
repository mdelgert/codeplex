using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VESSEA.Core.Models;
using VESSEA.Core.DB;

namespace VESSEA.Core.Buisness
{


    //http://unitofwork.codeplex.com/

    //http://robrich.org/archive/2012/04/18/Design-Patterns-for-data-persistence-Unit-of-Work-Pattern-and.aspx



    public class CRUDApplicationLog
    {

        //VESSEA.Core.DB.EntitiesContext DB = new VESSEA.Core.DB.EntitiesContext();

        public void Create(string logText)
        {

            //http://stackoverflow.com/questions/10646111/entity-framework-migrations-enable-automigrations-along-with-added-migration
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<VESSEA.Core.Context.VESSEAContext, MyConfiguration>());

            //http://www.codeguru.com/csharp/article.php/c19999/Understanding-Database-Initializers-in-Entity-Framework-Code-First.htm
            //Auto drop and create database during development
            //Database.SetInitializer(new DropCreateDatabaseAlways<VESSEA.Core.Context.VESSEAContext>());

            //Database.SetInitializer(new DropCreateDatabaseAlways<VESSEA.Core.DB.EntitiesContext>());

            //using (var a = DB.Database)
            //{
            //    var r = new ApplicationLog
            //    {
            //        LogText = logText
            //    };

            //    a.ApplicationLogs.Add(r);
            //    a.SaveChanges();

            //};


            //http://blogs.microsoft.co.il/blogs/gilf/archive/2010/02/07/entity-framework-context-lifetime-best-practices.aspx

            //http://stackoverflow.com/questions/824330/should-entity-framework-context-be-put-into-using-statement

            using (VESSEA.Core.DB.EntitiesContext DB = new VESSEA.Core.DB.EntitiesContext())
            {
                var r = new ApplicationLog
                {
                    LogText = logText
                };

                DB.ApplicationLogs.Add(r);
                DB.SaveChanges();
            };

            //using (var unitOfWork = new UnitOfWork())
            //{
            //    var r = new ApplicationLog
            //    {
            //        LogText = logText
            //    };

            //    unitOfWork.ApplicationLogs.Add(r);

            //    unitOfWork.Complete();

            //}

            


        }


        public void ReadRows()
        {

            using (VESSEA.Core.DB.EntitiesContext DB = new VESSEA.Core.DB.EntitiesContext())
            {
                var query = (from r in DB.ApplicationLogs
                             select r);

                foreach (ApplicationLog a in query)
                {
                    Console.WriteLine(a.LogText.ToString());
                };

            };

            //using (var unitOfWork = new UnitOfWork())
            //{
            //    var query = (from r in unitOfWork.ApplicationLogs
            //                 select r);

            //    foreach (ApplicationLog a in query)
            //    {
            //        Console.WriteLine(a.LogText.ToString());
            //    };
            //};


        }

    }


    public class MyConfiguration : System.Data.Entity.Migrations.DbMigrationsConfiguration<VESSEA.Core.DB.EntitiesContext>
    {
        public MyConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
        }
    }

}
