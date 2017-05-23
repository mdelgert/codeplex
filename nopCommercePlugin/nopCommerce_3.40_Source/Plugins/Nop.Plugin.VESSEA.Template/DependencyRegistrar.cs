using Autofac;
using Autofac.Core;
using Nop.Core.Data;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Data;
using Nop.Plugin.VESSEA.Template.Data;
using Nop.Plugin.VESSEA.Template.Domain;
using Nop.Plugin.VESSEA.Template.Services;
using Nop.Web.Framework.Mvc;

namespace Nop.Plugin.VESSEA.Template
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            builder.RegisterType<VESSEAService>().As<IVESSEAService>().InstancePerLifetimeScope();

            //data context
            this.RegisterPluginDataContext<VESSEATemplateObjectContext>(builder, "nop_object_context_vessea_template");

            //override required repository with our custom context
            builder.RegisterType<EfRepository<VESSEATemplateRecord>>()
                .As<IRepository<VESSEATemplateRecord>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>("nop_object_context_vessea_template"))
                .InstancePerLifetimeScope();
        }

        public int Order
        {
            get { return 1; }
        }
    }
}
