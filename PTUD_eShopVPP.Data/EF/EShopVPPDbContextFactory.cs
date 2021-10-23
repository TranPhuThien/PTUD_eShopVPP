using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PTUD_eShopVPP.Data.EF
{
    public class EShopVPPDbContextFactory : IDesignTimeDbContextFactory<EShopVPPDbContext>
    {
        public EShopVPPDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("PTUD_eShopVPPDb");

            var optionsBuilder = new DbContextOptionsBuilder<EShopVPPDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new EShopVPPDbContext(optionsBuilder.Options);
        }
    }
}
