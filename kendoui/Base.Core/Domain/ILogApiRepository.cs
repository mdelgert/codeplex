using System;
using System.Linq;
using Base.Core.Models;

namespace Base.Core.Domain
{
    public interface ILogApiRepository
    {
        void Add(LogApi objectModel);
        void Update(LogApi objectModel);
        void Delete(LogApi objectModel);
        LogApi GetById(int objectModel);
    }
}
