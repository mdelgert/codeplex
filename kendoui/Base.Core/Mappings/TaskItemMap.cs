using System;
using FluentNHibernate.Mapping;
using Base.Core.Models;

namespace Base.Core.Mappings
{
    public class TaskItemMap : ClassMap<TaskItem>
    {
        public TaskItemMap()
        {
            Table("TaskItem");
            LazyLoad();
            Id(x => x.KeyId).GeneratedBy.Identity().Column("KeyId");
            Map(x => x.CreateDate).Column("CreateDate");
            Map(x => x.TaskName).Column("TaskName");
        }
    }
}
