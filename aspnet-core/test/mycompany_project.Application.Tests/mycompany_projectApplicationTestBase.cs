using Volo.Abp.Modularity;

namespace mycompany_project;

public abstract class mycompany_projectApplicationTestBase<TStartupModule> : mycompany_projectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
