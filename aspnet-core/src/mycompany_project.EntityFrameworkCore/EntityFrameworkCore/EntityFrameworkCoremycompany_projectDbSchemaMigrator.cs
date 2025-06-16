using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using mycompany_project.Data;
using Volo.Abp.DependencyInjection;

namespace mycompany_project.EntityFrameworkCore;

public class EntityFrameworkCoremycompany_projectDbSchemaMigrator
    : Imycompany_projectDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoremycompany_projectDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the mycompany_projectDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<mycompany_projectDbContext>()
            .Database
            .MigrateAsync();
    }
}
