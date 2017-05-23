using System;
using System.Text;
using System.Collections.Generic;


namespace Base.ConsoleApplicationFluentNHibernate.Domain
{

    public class Tasklist
    {
        public virtual int Taskid { get; set; }
        public virtual string Taskname { get; set; }
        public virtual string Tasktext { get; set; }
        public virtual DateTime? Createdate { get; set; }
    }
}

