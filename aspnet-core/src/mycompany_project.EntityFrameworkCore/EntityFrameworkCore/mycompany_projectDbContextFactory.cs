using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Aumerial.EntityFrameworkCore;

namespace mycompany_project.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class mycompany_projectDbContextFactory : IDesignTimeDbContextFactory<mycompany_projectDbContext>
{
    public mycompany_projectDbContext CreateDbContext(string[] args)
    {
        mycompany_projectEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<mycompany_projectDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new mycompany_projectDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../mycompany_project.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
