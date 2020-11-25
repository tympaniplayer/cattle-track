using Volo.Abp.Settings;

namespace CattleTrack.Settings
{
    public class CattleTrackSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CattleTrackSettings.MySetting1));
        }
    }
}
