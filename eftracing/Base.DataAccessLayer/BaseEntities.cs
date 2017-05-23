// 
// Copyright © 2012 Matthew David Elgert - mdelgert@yahoo.com
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2.1 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA 
// 
// Author: Matthew David Elgert - http://www.codeplex.com/site/users/view/mdelgert
// 
  
using System;
using System.Data.Entity;
using System.Linq;
using Base.DataModel;

namespace Base.DataAccessLayer
{
    public class BaseEntities : DbContext
    {
        public DbSet<LogApplicationModel> LogApplication { get; set; }

        public DbSet<LogExceptionModel> LogException { get; set; }

        //public void CreateIndexs()
        //{
        //    Database.ExecuteSqlCommand("CREATE NONCLUSTERED INDEX [IX_CreatedOn] ON dbo.LogApplication ([CreatedOn])");
        //}
        public void Save()
        {
            try
            {
                this.SaveChanges();
                Console.WriteLine("Save success:");
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Save failed:" + ex.InnerException.ToString());
                Console.WriteLine(string.Format("Stack Trace:{0}", ex.StackTrace.ToString()));
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /// <summary>
            /// On specify table names examples // 
            /// modelBuilder.Entity<YourModel>().ToTable("DatabaseTableName", schemaName: "SchemaName");
            /// modelBuilder.Entity<YourModel>().ToTable("DatabaseTableName"); //Default schema dbo
            /// </summary>
            modelBuilder.Entity<LogApplicationModel>().ToTable("LogApplication");
            modelBuilder.Entity<LogExceptionModel>().ToTable("LogException");
        }
    }
}