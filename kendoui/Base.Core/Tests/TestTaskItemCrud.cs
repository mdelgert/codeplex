using System;
using System.Linq;
using Base.Core.Models;
using Base.Core.Domain;
using Base.Core.Repositories;

namespace Base.Core.Tests
{
    public class TestTaskItemCrud
    {
        
        readonly ITaskItemRepository repository = new TaskItemRepositories();
        TaskItem modelObject = new TaskItem();

        public void TestCrud(int testsCount)
        {
            for (int i = 1; i <= testsCount; i++)
            {
                
                modelObject.CreateDate = System.DateTime.Now;
                modelObject.TaskName = "Test " + i.ToString();
                modelObject = TestCreate(modelObject);
                TestRead(modelObject.KeyId);
                modelObject.TaskName = modelObject.TaskName + "_Update";
                TestUpdate(modelObject);
                TestRead(modelObject.KeyId);

                //TestDelete(o);
            }

        }

        public TaskItem TestCreate(TaskItem o)
        {
            repository.Add(o);
            Console.WriteLine("Create KeyId=" + o.KeyId.ToString());
            return o;
        }

        public TaskItem TestRead(int keyId)
        {
            modelObject = repository.GetById(keyId);
            Console.WriteLine("Read KeyId=" + modelObject.KeyId.ToString());
            return modelObject;
        }

        public void TestUpdate(TaskItem o)
        {
            repository.Update(o);
            Console.WriteLine("Update KeyId=" + o.KeyId.ToString());
        }

        public void TestDelete(TaskItem o)
        {
            repository.Delete(o);
            Console.WriteLine("Delete LogApiId=" + o.KeyId.ToString());
        }

    }

}
