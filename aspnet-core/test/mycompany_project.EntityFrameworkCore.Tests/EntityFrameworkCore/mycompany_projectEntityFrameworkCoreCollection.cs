using Xunit;

namespace mycompany_project.EntityFrameworkCore;

[CollectionDefinition(mycompany_projectTestConsts.CollectionDefinitionName)]
public class mycompany_projectEntityFrameworkCoreCollection : ICollectionFixture<mycompany_projectEntityFrameworkCoreFixture>
{

}
