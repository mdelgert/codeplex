using Nop.Core;

namespace Nop.Plugin.VESSEA.Template.Domain
{
    /// <summary>
    /// Represents a VESSEA template record
    /// </summary>
    public partial class VESSEATemplateRecord : BaseEntity
    {
        public virtual int TemplateId { get; set; }
        public virtual bool Enabled { get; set; }
        public virtual string Name { get; set; }

    }
}