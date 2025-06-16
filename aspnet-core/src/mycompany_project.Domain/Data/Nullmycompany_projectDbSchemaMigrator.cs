using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace mycompany_project.Data;

/* This is used if database provider does't define
 * Imycompany_projectDbSchemaMigrator implementation.
 */
public class Nullmycompany_projectDbSchemaMigrator : Imycompany_projectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
