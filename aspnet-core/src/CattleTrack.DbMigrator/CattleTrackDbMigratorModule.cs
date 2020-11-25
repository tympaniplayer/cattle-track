using CattleTrack.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace CattleTrack.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CattleTrackEntityFrameworkCoreDbMigrationsModule),
        typeof(CattleTrackApplicationContractsModule)
        )]
    public class CattleTrackDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
