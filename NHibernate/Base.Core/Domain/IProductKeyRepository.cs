using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Core.Domain
{
    public interface IProductKeyRepository
    {
        void Add(ProductKey productkey);
        void Update(ProductKey productkey);
        void Delete(ProductKey productkey);
        ProductKey GetById(int RecID);
    }
}
