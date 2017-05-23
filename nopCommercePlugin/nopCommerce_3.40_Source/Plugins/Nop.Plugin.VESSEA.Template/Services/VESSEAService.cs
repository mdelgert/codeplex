using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nop.Core.Data;
using Nop.Plugin.VESSEA.Template.Domain;

namespace Nop.Plugin.VESSEA.Template.Services
{
    public partial class VESSEAService : IVESSEAService
    {
        #region Fields

        private readonly IRepository<VESSEATemplateRecord> _vtRepository;

        #endregion

        #region Ctor

        public VESSEAService(IRepository<VESSEATemplateRecord> vtRepository)
        {
            this._vtRepository = vtRepository;
        }

        #endregion


        #region Methods

        public virtual void DeleteVESSEATemplate(VESSEATemplateRecord vesseaTemplateRecord)
        {
            if (vesseaTemplateRecord == null)
                throw new ArgumentNullException("vesseaTemplateRecord");

            _vtRepository.Delete(vesseaTemplateRecord);
        }

        public virtual IList<VESSEATemplateRecord> GetAll()
        {
            var query = from vt in _vtRepository.Table
                        orderby vt.Id
                        select vt;
            var records = query.ToList();
            return records;
        }

        public virtual VESSEATemplateRecord GetById(int templateId)
        {
            if (templateId == 0)
                return null;

            return _vtRepository.GetById(templateId);
        }

        public virtual VESSEATemplateRecord GetByTemplateId(int templateId)
        {
            if (templateId == 0)
                return null;

            var query = from gp in _vtRepository.Table
                        where gp.TemplateId == templateId
                        orderby gp.Id
                        select gp;
            var record = query.FirstOrDefault();
            return record;
        }

        public virtual void InsertVESSEATemplateRecord(VESSEATemplateRecord vesseaTemplateRecord)
        {
            if (vesseaTemplateRecord == null)
                throw new ArgumentNullException("vesseaTemplateRecord");

            _vtRepository.Insert(vesseaTemplateRecord);
        }

        public virtual void UpdateVESSEATemplateRecord(VESSEATemplateRecord vesseaTemplate)
        {
            if (vesseaTemplate == null)
                throw new ArgumentNullException("vesseaTemplateRecord");

            _vtRepository.Update(vesseaTemplate);
        }

        #endregion
    }
}
