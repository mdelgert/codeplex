using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Base.Core
{
    public class TestMySQL
    {

        public void ReadDB()
        {

            string connectionString =
          "Server=192.168.1.35;" +
          "Database=mysql;" +
          "User ID=mdelgert;" +
          "Password=Password2013;" +
          "Pooling=false";
            IDbConnection dbcon;
            dbcon = new MySqlConnection(connectionString);
            dbcon.Open();
            IDbCommand dbcmd = dbcon.CreateCommand();
            // requires a table to be created named employee
            // with columns firstname and lastname
            // such as,
            //        CREATE TABLE employee (
            //           firstname varchar(32),
            //           lastname varchar(32));
            string sql =
                "SELECT TaskName from TaskList";
            dbcmd.CommandText = sql;
            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
                string _taskName = (string)reader["TaskName"];

                Console.WriteLine("Task Name: " + _taskName );
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
