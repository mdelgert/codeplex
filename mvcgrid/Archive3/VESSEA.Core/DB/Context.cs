using System;
using System.Transactions;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using VESSEA.Core.Models;

namespace VESSEA.Core.DB
{
    public class EntitiesContext : DbContext
    {
        public DbSet<ApplicationLog> ApplicationLogs { get; set; }
    }

    public class UnitOfWork : DbContext //, IDisposable 
    {
        

        public DbSet<ApplicationLog> ApplicationLogs { get; set; }

        //http://stackoverflow.com/questions/11982828/unit-of-work-pattern-with-database-transactions

        VESSEA.Core.DB.EntitiesContext _dbContext;
        
        //TransactionScope _transaction;

        public UnitOfWork()
        {
            _dbContext = new VESSEA.Core.DB.EntitiesContext();
            //_transaction = new TransactionScope();
        }

        public void Complete()
        {
            _dbContext.SaveChanges();
            //_transaction.Complete();
        }

        //public void Dispose()
        //{
        //    _dbContext.Dispose();
        //}

    }

}
