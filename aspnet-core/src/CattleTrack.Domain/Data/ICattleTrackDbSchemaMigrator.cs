using System.Threading.Tasks;

namespace CattleTrack.Data
{
    public interface ICattleTrackDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
