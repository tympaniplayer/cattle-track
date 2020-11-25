using CattleTrack.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CattleTrack
{
    [DependsOn(
        typeof(CattleTrackEntityFrameworkCoreTestModule)
        )]
    public class CattleTrackDomainTestModule : AbpModule
    {

    }
}