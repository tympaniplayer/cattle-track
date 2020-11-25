using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CattleTrack.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class CattleTrackMigrationsDbContextFactory : IDesignTimeDbContextFactory<CattleTrackMigrationsDbContext>
    {
        public CattleTrackMigrationsDbContext CreateDbContext(string[] args)
        {
            CattleTrackEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<CattleTrackMigrationsDbContext>()
                .UseNpgsql(configuration.GetConnectionString("Default"));

            return new CattleTrackMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../CattleTrack.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
