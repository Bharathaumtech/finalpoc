using mycompany_project.Samples;
using Xunit;

namespace mycompany_project.EntityFrameworkCore.Applications;

[Collection(mycompany_projectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<mycompany_projectEntityFrameworkCoreTestModule>
{

}
