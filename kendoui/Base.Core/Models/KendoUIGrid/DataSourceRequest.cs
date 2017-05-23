//  https://github.com/telerik/kendo-examples-asp-net/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Base.Core.Models.KendoUIGrid
{
    class DataSourceRequest
    {
        public int Take { get; set; }
        public int Skip { get; set; }
        public IEnumerable<Sort> Sort { get; set; }
        public Filter Filter { get; set; }
    }

}

