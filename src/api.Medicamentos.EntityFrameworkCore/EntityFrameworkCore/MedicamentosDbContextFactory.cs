using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace api.Medicamentos.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class MedicamentosDbContextFactory : IDesignTimeDbContextFactory<MedicamentosDbContext>
{
    public MedicamentosDbContext CreateDbContext(string[] args)
    {
        MedicamentosEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<MedicamentosDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new MedicamentosDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../api.Medicamentos.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
