using System.Collections.Generic;
using Nop.Plugin.VESSEA.Template.Domain;

namespace Nop.Plugin.VESSEA.Template.Services
{
    public partial interface IVESSEAService
    {
        void DeleteVESSEATemplate(VESSEATemplateRecord vesseaTemplateRecord);

        IList<VESSEATemplateRecord> GetAll();

        VESSEATemplateRecord GetById(int templateId);

        VESSEATemplateRecord GetByTemplateId(int templateId);

        void InsertVESSEATemplateRecord(VESSEATemplateRecord vesseaTemplateRecord);

        void UpdateVESSEATemplateRecord(VESSEATemplateRecord vesseaTemplateRecord);

    }
}