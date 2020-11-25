using Volo.Abp.Modularity;

namespace CattleTrack
{
    [DependsOn(
        typeof(CattleTrackApplicationModule),
        typeof(CattleTrackDomainTestModule)
        )]
    public class CattleTrackApplicationTestModule : AbpModule
    {

    }
}