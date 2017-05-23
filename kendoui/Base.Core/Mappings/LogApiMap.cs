using System;
using FluentNHibernate.Mapping;
using Base.Core.Models;

namespace Base.Core.Mappings
{
    public class LogApiMap : ClassMap<LogApi>
    {
        public LogApiMap()
        {
            Table("LogApi");
            LazyLoad();
            Id(x => x.LogApiId).GeneratedBy.Identity().Column("LogApiId");
            Map(x => x.CreateDate).Column("CreateDate");
            Map(x => x.Message).Column("Message").CustomSqlType("TEXT");
            //Map(x => x.Message).Column("Message").CustomSqlType("nvarchar(MAX)"); 
            //Sqlite does not have data type nvarchar(MAX)
            //https://www.sqlite.org/datatypes.html
            //http://www.sqlite.org/datatype3.html
            //http://www.sqlite.org/c3ref/c_blob.html
        }
    }
}

//Map(x => x.Message).Column("Message").CustomSqlType("nvarchar(55)");  //How to Specify Columntype in fluent nHibernate? - http://stackoverflow.com/questions/2645024/how-to-specify-columntype-in-fluent-nhibernate
