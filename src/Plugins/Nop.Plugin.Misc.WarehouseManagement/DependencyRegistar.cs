using Autofac;
using Autofac.Core;
using Nop.Core;
using Nop.Core.Configuration;
using Nop.Core.Data;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Data;
using Nop.Plugin.Misc.WarehouseManagement.Data;
using Nop.Plugin.Misc.WarehouseManagement.Services;
using Nop.Web.Framework.Mvc;
using System.Linq;
using System.Reflection;

namespace Nop.Plugin.Misc.WarehouseManagement
{
    public class DependencyRegistrar : IDependencyRegistrar
    {        
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            builder.RegisterType<DocumentService>().As<IDocumentService>().InstancePerLifetimeScope();
            builder.RegisterType<PrintService>().As<IPrintService>().InstancePerLifetimeScope();

            this.RegisterPluginDataContext<WmDbContext>(builder, "nop_object_context_warehouse_management");

            var typesToRegister = Assembly.GetAssembly(typeof(WmDbContext)).GetTypes()
            .Where(type => !string.IsNullOrEmpty(type.Namespace))
            .Where(type => type.BaseType != null && type.BaseType == typeof(BaseEntity));

            foreach (var type in typesToRegister)
            {
                builder.RegisterType(typeof(EfRepository<>).MakeGenericType(type))
                       .As(typeof(IRepository<>).MakeGenericType(type))
                       .WithParameter(ResolvedParameter.ForNamed<IDbContext>("nop_object_context_warehouse_management"))
                       .InstancePerLifetimeScope();
            }


        }
     
        public int Order
        {
            get { return 1; }
        }
    }
}
