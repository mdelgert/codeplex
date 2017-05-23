using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using Base.ConsoleApplicationFluentNHibernate.Domain;

namespace Base.ConsoleApplicationFluentNHibernate.Mappings
{


    public class TasklistMap : ClassMap<Tasklist>
    {

        public TasklistMap()
        {
            Table("TaskList");
            LazyLoad();
            Id(x => x.Taskid).GeneratedBy.Identity().Column("TaskId");
            Map(x => x.Taskname).Column("TaskName").Length(50);
            Map(x => x.Tasktext).Column("TaskText");
            Map(x => x.Createdate).Column("CreateDate");
        }
    }
}
