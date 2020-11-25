using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace CattleTrack.Web
{
    [Dependency(ReplaceServices = true)]
    public class CattleTrackBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "CattleTrack";
    }
}
