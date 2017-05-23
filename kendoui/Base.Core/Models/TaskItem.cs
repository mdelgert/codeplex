using System;
using System.Linq;

namespace Base.Core.Models
{
    public class TaskItem
    {
        public virtual int KeyId { get; set; }
        public virtual System.DateTime CreateDate { get; set; }
        public virtual string TaskName { get; set; }

    }

}