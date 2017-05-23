using System;
using System.Text;
using System.Collections.Generic;

namespace Base.Core.Domain
{

    public class ProductKey
    {
        public virtual int RecID { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string ProductID { get; set; }
        public virtual string ProductKeyID { get; set; }
        public virtual string Vendor { get; set; }
        public virtual string Subscription { get; set; }
    }
}