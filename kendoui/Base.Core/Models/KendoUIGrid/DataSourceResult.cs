//http://www.telerik.com/support/code-library/grid-web-service---crud

using System;
using System.Collections;
using System.Linq;

namespace Base.Core.Models.KendoUIGrid
{
    /// <summary>
    /// Describes the result of Kendo DataSource read operation. 
    /// </summary>
    public class DataSourceResult
    {
        /// <summary>
        /// Represents a single page of processed data.
        /// </summary>
        public IEnumerable Data { get; set; }

        /// <summary>
        /// The total number of records available.
        /// </summary>
        public int Total { get; set; }
    }

}



