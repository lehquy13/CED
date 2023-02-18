using CED.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CED.Permissions;

public class CEDPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CEDPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CEDPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CEDResource>(name);
    }
}
