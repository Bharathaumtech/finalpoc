using Volo.Abp.Modularity;

namespace mycompany_project;

/* Inherit from this class for your domain layer tests. */
public abstract class mycompany_projectDomainTestBase<TStartupModule> : mycompany_projectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
