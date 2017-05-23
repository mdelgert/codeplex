using System;
using System.Linq;

namespace Base.Core.Models
{
    public class LogApi
    {
        public virtual int LogApiId { get; set; }
        public virtual System.DateTime CreateDate { get; set; }
        public virtual string Message { get; set; }
    }

}

