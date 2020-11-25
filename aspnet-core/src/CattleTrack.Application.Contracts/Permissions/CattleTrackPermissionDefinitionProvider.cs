using CattleTrack.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CattleTrack.Permissions
{
    public class CattleTrackPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CattleTrackPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(CattleTrackPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CattleTrackResource>(name);
        }
    }
}
