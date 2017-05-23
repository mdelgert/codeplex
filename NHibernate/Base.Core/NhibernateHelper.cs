﻿/*  
 *  Copyright © 2013 Matthew David Elgert - mdelgert@yahoo.com, Project URL: https://nhibernate.codeplex.com/, License: https://nhibernate.codeplex.com/license - GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007 Copyright © 2007 Free Software Foundation, Inc. <http://fsf.org/> Everyone is permitted to copy and distribute verbatim copies of this license document, but changing it is not allowed. Preamble The GNU General Public License is a free, copyleft license for software and other kinds of works. The licenses for most software and other practical works are designed to take away your freedom to share and change the works. By contrast, the GNU General Public License is intended to guarantee your freedom to share and change all versions of a program--to make sure it remains free software for all its users. We, the Free Software Foundation, use the GNU General Public License for most of our software; it applies also to any other work released this way by its authors. You can apply it to your programs, too. When we speak of free software, we are referring to freedom, not price. Our General Public Licenses are designed to make sure that you have the freedom to distribute copies of free software (and charge for them if you wish), that you receive source code or can get it if you want it, that you can change the software or use pieces of it in new free programs, and that you know you can do these things. To protect your rights, we need to prevent others from denying you these rights or asking you to surrender the rights. Therefore, you have certain responsibilities if you distribute copies of the software, or if you modify it: responsibilities to respect the freedom of others. For example, if you distribute copies of such a program, whether gratis or for a fee, you must pass on to the recipients the same freedoms that you received. You must make sure that they, too, receive or can get the source code. And you must show them these terms so they know their rights. Developers that use the GNU GPL protect your rights with two steps: (1) assert copyright on the software, and (2) offer you this License giving you legal permission to copy, distribute and/or modify it. For the developers' and authors' protection, the GPL clearly explains that there is no warranty for this free software. For both users' and authors' sake, the GPL requires that modified versions be marked as changed, so that their problems will not be attributed erroneously to authors of previous versions. Some devices are designed to deny users access to install or run modified versions of the software inside them, although the manufacturer can do so. This is fundamentally incompatible with the aim of protecting users' freedom to change the software. The systematic pattern of such abuse occurs in the area of products for individuals to use, which is precisely where it is most unacceptable. Therefore, we have designed this version of the GPL to prohibit the practice for those products. If such problems arise substantially in other domains, we stand ready to extend this provision to those domains in future versions of the GPL, as needed to protect the freedom of users. Finally, every program is threatened constantly by software patents. States should not allow patents to restrict development and use of software on general-purpose computers, but in those that do, we wish to avoid the special danger that patents applied to a free program could make it effectively proprietary. To prevent this, the GPL assures that patents cannot be used to render the program non-free. 
 *  
 *  Author: Matthew David Elgert, Authored Date: 10/14/2013, Modified Date: 10/14/2013
 *  
 *  Default Namespace: Base.ConsoleApplication
 *  
 *  Notes:
 * 
 */

//Nhibernate simple Select, Insert, Update and Delete http://rochcass.wordpress.com/2013/03/14/nhibernate-simple-insert-update-and-delete/#more-644 http://www.twiggle-web-design.com/tutorials/nhibernate/nhibernate.html

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;

using Base.Core.Domain;

namespace Base.Core
{
    public class NhibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactoryTasklist
        {
            get
            {
                if (_sessionFactory == null)
                {

                    var configuration = new Configuration();

                    configuration.Configure();

                    configuration.AddAssembly(typeof(Tasklist).Assembly);

                    //https://nhibernate.jira.com/browse/NH-2965

                    //http://www.symbolsource.org/Public/Metadata/NuGet/Project/Automatonymous.NHibernate/0.8.3/Release/.NETFramework,Version%3Dv4.0/Automatonymous.NHibernateIntegration/Automatonymous.NHibernateIntegration/SqlServerSessionFactoryProvider.cs?ImageName=Automatonymous.NHibernateIntegration

                    //http://stackoverflow.com/questions/3406801/why-is-nhibernate-refusing-to-batch-inserts

                    configuration.SetProperty("adonet.batch_size", "0"); //Fixes MSSQL errors with Nhibernate

                    _sessionFactory = configuration.BuildSessionFactory();


                    ////configuration.AddFile("Tasklist.hbm.xml");
                    //var configuration = new Configuration();
                    //configuration.DataBaseIntegration(c => c.Dialect<MsSql2012Dialect>());
                    //configuration.SetProperty("connection.connection_string", "Data Source=192.168.1.14;Initial Catalog=NHibernate; UID=NHibernate;pwd=Password2013;Integrated Security=False")
                    //    //configuration.SetProperty("connection.connection_string_name", "DefaultConnection")
                    //.SetProperty("connection.driver_class", "NHibernate.Driver.SqlClientDriver")
                    //    .SetProperty("connection.provider", "NHibernate.Connection.DriverConnectionProvider");
                    //configuration.AddAssembly(typeof(Tasklist).Assembly);
                    //_sessionFactory = configuration.BuildSessionFactory();

                }

                return _sessionFactory;

            }
        
        }

        private static ISessionFactory SessionFactoryProductKey
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var configuration = new Configuration();
                    configuration.Configure();
                    configuration.AddAssembly(typeof(ProductKey).Assembly);
                    configuration.SetProperty("adonet.batch_size", "0"); //Fixes MSSQL errors with Nhibernate
                    _sessionFactory = configuration.BuildSessionFactory();
                }

                return _sessionFactory;

            }

        }

        public static ISession OpenSessionTasklist()
        {
            return SessionFactoryTasklist.OpenSession();
        }

        public static ISession OpenSessionProductKey()
        {
            return SessionFactoryProductKey.OpenSession();
        }
    }

}