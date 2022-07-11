using api.Medicamentos.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace api.Medicamentos.Permissions;

public class MedicamentosPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MedicamentosPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MedicamentosPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MedicamentosResource>(name);
    }
}
