using System;
using Base.Core.Utils.Nhibernate;
using NHibernate;
using Base.Core.Domain;
using Base.Core.Models;

namespace Base.Core.Repositories
{
    public class TaskItemRepositories : ITaskItemRepository
    {
        public void Add(TaskItem objectModel)
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

        public void Update(TaskItem objectModel)
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

        public void Delete(TaskItem objectModel)
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

        public TaskItem GetById(int keyId)
        {
            using (ISession session = SessionSetup.OpenSessionNhibernate())
                return session.Get<TaskItem>(keyId);
        }

    }

}