using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CattleTrack.Data
{
    /* This is used if database provider does't define
     * ICattleTrackDbSchemaMigrator implementation.
     */
    public class NullCattleTrackDbSchemaMigrator : ICattleTrackDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}