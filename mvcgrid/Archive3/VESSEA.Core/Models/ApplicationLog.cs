using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace VESSEA.Core.Models
{
    public class ApplicationLog
    {
        [Key]
        public int LogID { get; set; }
        public string LogText { get; set; }
        public string NEWFIELD { get; set; }
        public string NEWFIELDX { get; set; }
    }
}
