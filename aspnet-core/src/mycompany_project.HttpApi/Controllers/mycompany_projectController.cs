using mycompany_project.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace mycompany_project.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class mycompany_projectController : AbpControllerBase
{
    protected mycompany_projectController()
    {
        LocalizationResource = typeof(mycompany_projectResource);
    }
}
