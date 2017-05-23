using System;
using Base.Core.Utils.Nhibernate;
using NHibernate;
using Base.Core.Domain;
using Base.Core.Models;

namespace Base.Core.Repositories
{
    public class LogApiRepositories : ILogApiRepository
    {
        public void Add(LogApi objectModel)
        {
            using (ISession session = SessionSetup.OpenSessionNhibernate())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    session.Save(objectModel);
                    transaction.Commit(); //Save Changes in Database
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); //If error occurs, all changes will be reverted
                    throw ex;
                }
            }
        }

        public void Update(LogApi objectModel)
        {
            using (ISession session = SessionSetup.OpenSessionNhibernate())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    session.Update(objectModel);
                    transaction.Commit(); //Save Changes in Database
                }
                catch
                {
                    //If error occurs, all changes will be reverted
                    transaction.Rollback();
                }
            }
        }

        public void Delete(LogApi objectModel)
        {

            using (ISession session = SessionSetup.OpenSessionNhibernate())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    session.Delete(objectModel);
                    transaction.Commit(); //Save Changes in Database
                }
                catch
                {
                    transaction.Rollback(); //If error occurs, all changes will be reverted
                }
            }
        }

        public LogApi GetById(int keyId)
        {
            using (ISession session = SessionSetup.OpenSessionNhibernate())
                return session.Get<LogApi>(keyId);
        }

    }

}