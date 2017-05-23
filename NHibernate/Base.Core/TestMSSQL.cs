using System;
using System.Data;
using System.Data.SqlClient;

//http://www.mono-project.com/SQL_Client

namespace Base.Core
{
    public class TestMSSQL
    {

        public void ReadDB()
        {

            //<add name="DefaultConnection" connectionString="Data Source=192.168.1.14;Database=NHibernate;UID=NHibernate;pwd=Password2013;MultipleActiveResultSets=True;" providerName="System.Data.SqlClient"/>

            string connectionString =
            "Server=192.168.1.14;" +
            "Database=NHibernate;" +
            "User ID=NHibernate;" +
            "Password=Password2013;" //+ "Integrated Security=SSPI"
            ;
            
            IDbConnection dbcon;
            dbcon = new SqlConnection(connectionString);
            dbcon.Open();
            IDbCommand dbcmd = dbcon.CreateCommand();
            string sql =
                "SELECT TaskName " +
                "FROM TaskList";
            dbcmd.CommandText = sql;
            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
                string _taskName = (string)reader["TaskName"];
                Console.WriteLine("Task: " + _taskName);
            }
            // clean up
            reader.Close();
            reader = null;
            dbcmd.Dispose();
            dbcmd = null;
            dbcon.Close();
            dbcon = null;

        }


    }

}
