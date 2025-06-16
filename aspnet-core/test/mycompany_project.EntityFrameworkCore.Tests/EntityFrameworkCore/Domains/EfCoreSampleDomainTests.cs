using mycompany_project.Samples;
using Xunit;

namespace mycompany_project.EntityFrameworkCore.Domains;

[Collection(mycompany_projectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<mycompany_projectEntityFrameworkCoreTestModule>
{

}
