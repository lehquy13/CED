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

        var subjectsPermission = myGroup
            .AddPermission(CEDPermissions.Subject.Default, L("Permission:Subjects"));
        subjectsPermission
            .AddChild(CEDPermissions.Subject.Create, L("Permission:Subjects.Create"));
        subjectsPermission
            .AddChild(CEDPermissions.Subject.Edit, L("Permission:Subjects.Edit"));
        subjectsPermission
            .AddChild(CEDPermissions.Subject.Delete, L("Permission:Subjects.Delete"));

        var classInformartionsPermission = myGroup
            .AddPermission(CEDPermissions.ClassInformation.Default, L("Permission:ClassInformations"));
        classInformartionsPermission
            .AddChild(CEDPermissions.ClassInformation.Create, L("Permission:ClassInformations.Create"));
        classInformartionsPermission
            .AddChild(CEDPermissions.ClassInformation.Edit, L("Permission:ClassInformations.Edit"));
        classInformartionsPermission
            .AddChild(CEDPermissions.ClassInformation.Delete, L("Permission:ClassInformations.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CEDResource>(name);
    }
}
