using mycompany_project.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace mycompany_project.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(mycompany_projectEntityFrameworkCoreModule),
    typeof(mycompany_projectApplicationContractsModule)
    )]
public class mycompany_projectDbMigratorModule : AbpModule
{
}
