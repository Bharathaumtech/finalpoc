using Volo.Abp.Modularity;

namespace mycompany_project;

[DependsOn(
    typeof(mycompany_projectApplicationModule),
    typeof(mycompany_projectDomainTestModule)
)]
public class mycompany_projectApplicationTestModule : AbpModule
{

}
