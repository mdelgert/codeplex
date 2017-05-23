
using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using Base.Core.Mappings;

namespace Base.Core.Utils.Nhibernate
{
    public class SessionSetup
    {

        private static readonly bool dbUseMonoSqliteDriver = AppSettingsCfg.GetUseMonoSqliteDriverKey();
        private static readonly bool dbBuildSchema = AppSettingsCfg.GetBuildSchemaKey();
        private static readonly string dbFile = AppSettingsCfg.GetDbFileKey();
        private static ISessionFactory sessionFactory;

        private static ISessionFactory SessionFactoryNhibernate
        {
            get
            {

                if (sessionFactory == null)
                {
                    try
                    {
                        if (dbUseMonoSqliteDriver)
                        {
                            sessionFactory = Fluently.Configure()
                                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<LogApiMap>())

                                // ################################# Use this line for release comment out section below.###############################
                                .Database(MonoSqliteConfiguration.Standard.ConnectionString("data source=|DataDirectory|" + dbFile))
                                // ################################# Use this line for release comment out section below.###############################
                                
                                // ################################ Debug and Sqlite tracing section ###################################################
                                //.Database(MonoSqliteConfiguration.Standard.ConnectionString("data source=|DataDirectory|" + dbFile).ShowSql())
                                //.ExposeConfiguration(x =>
                                //   {
                                //       x.SetInterceptor(new SqlStatementInterceptor()); //Comment out for release to increase performance
                                //   })
                                // ################################ Debug and Sqlite tracing section ###################################################
                                
                                .ExposeConfiguration(BuildSchema)
                                .BuildSessionFactory();

                        }
                        else
                        {
                            sessionFactory = Fluently.Configure()
                                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<LogApiMap>())
                                .ExposeConfiguration(BuildSchema)
                                
                                .ExposeConfiguration(x =>
                                   {
                                       // ################################ Debug and Sqlite tracing section ###################################################
                                       //x.SetInterceptor(new SqlStatementInterceptor()); //Comment out for release to increase performance
                                       // #####################################################################################################################
                                       x.SetProperty("adonet.batch_size", "0"); //Fixes Mono MSSQL errors with nhibernate. Mono MySQL works with this setting enabled or not.
                                   })
                               
                                 .BuildSessionFactory();
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.InnerException.ToString());
                    }

                }

                return sessionFactory;

            }

        }

        private static void BuildSchema(Configuration config)
        {
            if (dbBuildSchema)
            {
                new SchemaExport(config).Create(false, true);
            }

        }

        public static ISession OpenSessionNhibernate()
        {
            return SessionFactoryNhibernate.OpenSession();
        }

    }
}

//.Mappings(m => m.FluentMappings.AddFromAssemblyOf<NoteMap>())
//.Mappings(m => m.FluentMappings.AddFromAssemblyOf<TaskMap>())

//Mono MySQL
//.Database(MySQLConfiguration.Standard.ConnectionString("Server=192.168.1.197;Database=APPDB;User ID=webuser;Password=Password2014;").ShowSql())

//.Database(MySQLConfiguration
//    .Standard
//    .ConnectionString("Data Source=192.168.1.197;Initial Catalog=APPDB;User ID=webuser;Password=Password2014")
//    .Provider("MySql.Data.MySqlClient"))

//var configuration = new Configuration();
//configuration.Configure();
//configuration.SetProperty("adonet.batch_size", "0"); //Fixes Mono MSSQL errors with nhibernate

//http://daveden.wordpress.com/2012/04/05/how-to-use-fluent-nhibernate-with-auto-mappings/

//if (DbExists(config))
//    return; 

//Project needs to reference sqlite3.dll mono works fine with this dll
//http://stackoverflow.com/questions/5884359/fluent-nhibernate-create-database-schema-only-if-not-existing
//.Database(MonoSqliteConfiguration.Standard.UsingFile(DbFile)) //http://stackoverflow.com/questions/7626251/using-nhibernate-and-mono-data-sqlite
//http://webbo.sourceforge.net/tut_aspnet_sqlite.php
//https://github.com/MrSpiffy/MonoSqliteConfiguration/blob/master/MonoSqliteConfiguration.cs
//http://stackoverflow.com/questions/7626251/using-nhibernate-and-mono-data-sqlite
//http://stackoverflow.com/questions/6203597/trying-to-using-nhibernate-with-mono-sqlite-cant-find-system-data-sqlite
//http://blog.miraclespain.com/archive/2009/Aug-26.html
//using System.Data;
//using System.IO;
//using Base.Core.Domain;
//private const string DbFile = "APPDB.db";