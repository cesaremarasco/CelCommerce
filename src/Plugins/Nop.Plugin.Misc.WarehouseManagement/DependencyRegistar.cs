using Autofac;
using Autofac.Core;
using Nop.Core.Configuration;
using Nop.Core.Data;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Data;
using Nop.Plugin.Misc.WarehouseManagement.Data;
using Nop.Plugin.Misc.WarehouseManagement.Domain;
using Nop.Plugin.Misc.WarehouseManagement.Services;
using Nop.Web.Framework.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.WarehouseManagement
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        /// <summary>
        /// Register services and interfaces
        /// </summary>
        /// <param name="builder">Container builder</param>
        /// <param name="typeFinder">Type finder</param>
        /// <param name="config">Config</param>
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            builder.RegisterType<DocumentService>().As<IDocumentService>().InstancePerLifetimeScope();            

            this.RegisterPluginDataContext<WmDbContext>(builder, "WmDbContext");
           
            builder.RegisterType<EfRepository<Document>>()
                .As<IRepository<Document>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>("WmDbContext"))
                .InstancePerLifetimeScope();
        }

        /// <summary>
        /// Order of this dependency registrar implementation
        /// </summary>
        public int Order
        {
            get { return 1; }
        }
    }
}
