using Volo.Abp.Settings;

namespace mycompany_project.Settings;

public class mycompany_projectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(mycompany_projectSettings.MySetting1));
    }
}
