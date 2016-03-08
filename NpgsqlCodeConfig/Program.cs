using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NpgsqlCodeConfig.Model;

namespace NpgsqlCodeConfig
{
    static class Program
    {
        /// <summary>
        /// Returns null if an string is empty
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static string NullIfEmpty(this string str) => str == "" ? null : str;

        static string Ask(string question, string @default)
        {
            Console.WriteLine($"{question}? ({@default})");
            return Console.ReadLine().NullIfEmpty() ?? @default;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("If the database doesn't exist it will be created!");
            Console.WriteLine();
            if (Ask ("Enable migrations?", "yes") == "yes")
                Db.ConfigureMigrations();

            //Generate connection string from user input
            var host = Ask("Host", "localhost");
            var port = Ask("Port", "5432");
            var database = Ask("Database", "delete_me");
            var username = Ask("Username", "postgres");
            var password = Ask("Password", "123456");

            var connectionString = $"Host={host};Port={port};Database={database};Username={username};Password={password};";

            //Show the number of products
            using (var C = new Db(connectionString))
            {
                var productos = C.Product.Count();
                Console.WriteLine($"Product count: {productos}");
            }

            Console.WriteLine("ok :)");
            Console.ReadKey();
        }
    }
}
