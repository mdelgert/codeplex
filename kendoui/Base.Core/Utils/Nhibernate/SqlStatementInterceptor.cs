//http://stackoverflow.com/questions/2134565/how-to-configure-fluent-nhibernate-to-output-queries-to-trace-or-debug-instead-o

using System;
using System.Diagnostics;
using NHibernate;


public class SqlStatementInterceptor : EmptyInterceptor
{
    public override NHibernate.SqlCommand.SqlString OnPrepareStatement(NHibernate.SqlCommand.SqlString sql)
    {
        //Trace.WriteLine(sql.ToString());
        Console.WriteLine(sql.ToString());
        return sql;
    }
}

