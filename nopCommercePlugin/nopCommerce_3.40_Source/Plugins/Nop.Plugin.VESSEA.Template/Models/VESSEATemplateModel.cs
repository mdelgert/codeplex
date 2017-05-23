using System.Collections.Generic;
using System.Web.Mvc;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;

namespace Nop.Plugin.VESSEA.Template.Models
{
    public class VESSEATemplateModel : BaseNopModel
    {
        public int TemplateId { get; set; }

        [NopResourceDisplayName("Plugins.VESSEA.Template.Fields.Enabled")]
        public bool Enabled { get; set; }

        [NopResourceDisplayName("Plugins.VESSEA.Template.Fields.Name")]
        public string Name { get; set; }


    }
}