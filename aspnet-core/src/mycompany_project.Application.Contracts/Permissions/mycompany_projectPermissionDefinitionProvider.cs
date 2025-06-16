using mycompany_project.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace mycompany_project.Permissions;

public class mycompany_projectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(mycompany_projectPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(mycompany_projectPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<mycompany_projectResource>(name);
    }
}
