using System;
using System.Linq;
using Base.Core.Models;

namespace Base.Core.Domain
{
    public interface ITaskItemRepository
    {
        void Add(TaskItem objectModel);
        void Update(TaskItem objectModel);
        void Delete(TaskItem objectModel);
        TaskItem GetById(int objectModel);
    }
}
