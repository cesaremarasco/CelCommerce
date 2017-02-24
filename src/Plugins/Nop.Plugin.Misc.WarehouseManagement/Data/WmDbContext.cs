using Nop.Data;
using System.Data.Entity;
using System;
using Nop.Core;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Text;
using Nop.Plugin.Misc.WarehouseManagement.Domain;

namespace Nop.Plugin.Misc.WarehouseManagement.Data
{
    public class WmDbContext : DbContext, IDbContext
    {
        public bool ProxyCreationEnabled { get; set;  }

        public bool AutoDetectChangesEnabled { get; set; }
    

        public WmDbContext(string nameOrConnectionString) : base(nameOrConnectionString) { }       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DocumentCustomerMapping());
            modelBuilder.Configurations.Add(new DocumentMapping());

            modelBuilder.Entity<Document>().Ignore(x => x.Customers);

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
