using System;
using System.Collections.Generic;
using System.Text;
using mycompany_project.Localization;
using Volo.Abp.Application.Services;

namespace mycompany_project;

/* Inherit your application services from this class.
 */
public abstract class mycompany_projectAppService : ApplicationService
{
    protected mycompany_projectAppService()
    {
        LocalizationResource = typeof(mycompany_projectResource);
    }
}
