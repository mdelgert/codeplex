using System;
using System.ComponentModel.DataAnnotations;

namespace MVCGrid.Core.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ProductName { get; set; }
        public string ProductText { get; set; }
        public bool? Active { get; set; }
        public int? ProductTypeID { get; set; } //http://forums.asp.net/t/1703045.aspx/1
        public string TAGS { get; set; }
        public string ProductTypeName { get; set; }
    }
}
