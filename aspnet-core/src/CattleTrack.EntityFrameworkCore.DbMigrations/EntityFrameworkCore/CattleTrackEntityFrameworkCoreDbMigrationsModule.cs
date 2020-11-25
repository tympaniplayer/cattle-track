using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace CattleTrack.EntityFrameworkCore
{
    [DependsOn(
        typeof(CattleTrackEntityFrameworkCoreModule)
        )]
    public class CattleTrackEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<CattleTrackMigrationsDbContext>();
        }
    }
}
