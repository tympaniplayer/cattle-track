using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace CattleTrack.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(CattleTrackHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class CattleTrackConsoleApiClientModule : AbpModule
    {
        
    }
}
