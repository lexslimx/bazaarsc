using bazaarcs.api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace bazaarsc.infrastructure
{
    public class BazaarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = LoadConnectionString();
            optionsBuilder.UseSqlServer(connectionString);
        }

        private string LoadConnectionString()
        {            
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);
            var configuration = builder.Build();
            return configuration.GetConnectionString("BazaarDatabase");                        
        }

        public Listing Products { get; set; }
        public Order Orders { get; set; }
        public ActionLog ActionLogs { get; set; }
        public ListingCategory ProductCategories { get; set; }
        public Tag Tags { get; set; }
    }
}
