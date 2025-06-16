using Microsoft.Extensions.Localization;
using mycompany_project.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace mycompany_project;

[Dependency(ReplaceServices = true)]
public class mycompany_projectBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<mycompany_projectResource> _localizer;

    public mycompany_projectBrandingProvider(IStringLocalizer<mycompany_projectResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
