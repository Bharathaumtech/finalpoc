using Volo.Abp.Modularity;

namespace mycompany_project;

[DependsOn(
    typeof(mycompany_projectDomainModule),
    typeof(mycompany_projectTestBaseModule)
)]
public class mycompany_projectDomainTestModule : AbpModule
{

}
