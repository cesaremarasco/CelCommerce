using System.Data.Entity;
using Nop.Data;
using Nop.Data.Mapping.Common;
using System.Reflection;
using System.Linq;
using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Nop.Core;
using System.Collections.Generic;
using Nop.Data.Mapping.Customers;

namespace Nop.Plugin.Misc.WarehouseManagement.Data
{
    public class WmDbContext : DbContext, IDbContext
    {
        public bool ProxyCreationEnabled { get; set; }

        public bool AutoDetectChangesEnabled { get; set; }


        public WmDbContext(string nameOrConnectionString) 
            : base(nameOrConnectionString)
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {        
            var typesToRegister = Assembly.GetAssembly(typeof(WmDbContext)).GetTypes()
            .Where(type => !string.IsNullOrEmpty(type.Namespace))
            .Where(type => type.BaseType != null && type.BaseType.IsGenericType &&
                type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }           

            base.OnModelCreating(modelBuilder);
        }       

        public string CreateDatabaseInstallationScript()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateDatabaseScript();
        }

        public void Install()
        {
            //It's required to set initializer to null (for SQL Server Compact).
            //otherwise, you'll get something like "The model backing the 'your context name' context has changed since the database was created. Consider using Code First Migrations to update the database"
            Database.SetInitializer<WmDbContext>(null);

            Database.ExecuteSqlCommand(CreateDatabaseInstallationScript());

            SaveChanges();
        }

        public void Uninstall()
        {
            var cmd = new StringBuilder();

            cmd.Append("DROP TABLE Wm_Document_Customer_Mapping;");
            cmd.Append("DROP TABLE Wm_Document;");

            Database.ExecuteSqlCommand(cmd.ToString());

            SaveChanges();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        public IList<TEntity> ExecuteStoredProcedureList<TEntity>(string commandText, params object[] parameters) where TEntity : BaseEntity, new()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TElement> SqlQuery<TElement>(string sql, params object[] parameters)
        {
            throw new System.NotImplementedException();
        }

        public int ExecuteSqlCommand(string sql, bool doNotEnsureTransaction = false, int? timeout = null, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Detach(object entity)
        {
            throw new NotImplementedException();
        }
    }    
}
