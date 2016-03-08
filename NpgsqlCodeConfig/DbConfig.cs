using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace NpgsqlCodeConfig
{
    /// <summary>
    /// Configure Npgsql dependencies that were originally setted on the config.xml file
    /// </summary>
    public class DbConfig : DbConfiguration
    {
        public DbConfig()
        {
            var provider = "Npgsql";
            SetProviderFactory(provider, NpgsqlFactory.Instance);
            SetProviderServices(provider, NpgsqlServices.Instance);
            SetDefaultConnectionFactory(new NpgsqlConnectionFactory());
        }
    }
}
