using System;
using System.Linq;

namespace Base.Core.Models
{
    public class User
    {
        public virtual int KeyId { get; set; }
        public virtual System.DateTime CreateDate { get; set; }
        public virtual System.DateTime LastUpdated { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }

    }

}
