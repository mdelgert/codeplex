using System.Data.Entity.ModelConfiguration;
using Nop.Plugin.VESSEA.Template.Domain;

namespace Nop.Plugin.VESSEA.Template.Data
{
    public partial class VESSEATemplateRecordMap : EntityTypeConfiguration<VESSEATemplateRecord>
    {
        public VESSEATemplateRecordMap()
        {
            this.ToTable("VESSEATemplate");
            this.HasKey(x => x.Id);
            ////Map the additional properties
            //Property(m => m.TemplateId);
            //Property(m => m.Enabled);
            //Property(m => m.Name);

        }
    }
}