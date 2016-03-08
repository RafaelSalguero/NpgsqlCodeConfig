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
        public static void ConfigureMigrations()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Db, Migrations.Configuration>(true));
        }

        public Db() : base(
        "Host=192.168.1.66;Port=5432;Database=delete_me_migrations;Username=postgres;Password=768512;"
        )
        { }

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
