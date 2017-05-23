using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base.Core.Models;
using Base.Core.Domain;
using Base.Core.Repositories;

namespace Base.Core.Tests
{
    public class TestLogApi
    {
        public void RunAllTests(int testsCount)
        {
            for (int i = 1; i <= testsCount; i++)
            {
                LogApi objectModel = new LogApi();
                objectModel.CreateDate = System.DateTime.Now;
                objectModel.Message = "Test " + i.ToString();

                objectModel = TestCreate(objectModel);
                TestRead(objectModel.LogApiId);
                objectModel.Message = objectModel.Message + "_Update";
                TestUpdate(objectModel);
                //TestDelete(objectModel);
            }
        }

        public LogApi TestCreate(LogApi objectModel)
        {
            ILogApiRepository r = new LogApiRepositories();
            r.Add(objectModel);
            Console.WriteLine("Create LogApiId=" + objectModel.LogApiId.ToString());
            return objectModel;
        }

        public void TestRead(int keyId)
        {
            LogApi o = new LogApi();
            ILogApiRepository r = new LogApiRepositories();
            o = r.GetById(keyId);
            Console.WriteLine("Read LogApiId=" + o.LogApiId.ToString());
        }

        public void TestUpdate(LogApi objectModel)
        {
            ILogApiRepository r = new LogApiRepositories();
            r.Update(objectModel);
            Console.WriteLine("Update LogApiId=" + objectModel.LogApiId.ToString());
        }

        public void TestDelete(LogApi objectModel)
        {
            ILogApiRepository r = new LogApiRepositories();
            r.Delete(objectModel);
            Console.WriteLine("Delete LogApiId=" + objectModel.LogApiId.ToString());
        }

    }

}
