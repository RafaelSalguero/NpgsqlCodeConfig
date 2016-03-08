using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpgsqlCodeConfig.Model
{
    [DbConfigurationType(typeof(DbConfig))]
    public class Db : DbContext
    {
        /// <summary>
        /// Create a Db context with the given connction string
        /// </summary>
        /// <param name="ConnectionString"></param>
        public Db(string ConnectionString) : base(ConnectionString) { }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Client> Client { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // PostgreSQL uses the public schema by default - not dbo.
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
