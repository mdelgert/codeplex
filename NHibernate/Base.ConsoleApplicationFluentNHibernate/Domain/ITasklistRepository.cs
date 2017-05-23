

//Nhibernate simple Select, Insert, Update and Delete http://rochcass.wordpress.com/2013/03/14/nhibernate-simple-insert-update-and-delete/#more-644 http://www.twiggle-web-design.com/tutorials/nhibernate/nhibernate.html

using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
namespace Base.ConsoleApplicationFluentNHibernate.Domain
{
    public interface ITasklistRepository
    {
        void Add(Tasklist tasklist);
        void Update(Tasklist tasklist);
        void Delete(Tasklist tasklist);
        Tasklist GetById(int TaskId);
    }
}
