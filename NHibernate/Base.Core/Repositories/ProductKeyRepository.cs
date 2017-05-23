using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Base.Core;
using Base.Core.Domain;

namespace Base.Core.Repositories
{

    public class ProductKeyRepository : IProductKeyRepository
    {

        public void Add(ProductKey productkey)
        {
            using (ISession session = NhibernateHelper.OpenSessionProductKey())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    session.Save(productkey);
                    //Save Changes in Database
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    //If error occurs, all changes will be reverted
                    //transaction.Rollback();
                    throw ex;
                }
            }
        }

        public void Update(ProductKey productkey)
        {
            using (ISession session = NhibernateHelper.OpenSessionProductKey())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    session.Update(productkey);
                    //Save Changes in Database
                    transaction.Commit();
                }
                catch
                {
                    //If error occurs, all changes will be reverted
                    transaction.Rollback();
                }
            }
        }

        public void Delete(ProductKey productkey)
        {

            using (ISession session = NhibernateHelper.OpenSessionProductKey())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    session.Delete(productkey);
                    //Save Changes in Database
                    transaction.Commit();
                }
                catch
                {
                    //If error occurs, all changes will be reverted
                    transaction.Rollback();
                }
            }
        }

        public ProductKey GetById(int recID)
        {
            using (ISession session = NhibernateHelper.OpenSessionProductKey())
                return session.Get<ProductKey>(recID);
        }

        public IEnumerable<ProductKey> GetProdKey()
        {
            using (ISession session = NhibernateHelper.OpenSessionProductKey())
            {
                IEnumerable<ProductKey> productkeyData = session.CreateQuery("from ProductKey").Enumerable<ProductKey>();
                return productkeyData;
            }
        }

    }

}
