using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CattleTrack.Data;
using Volo.Abp.DependencyInjection;

namespace CattleTrack.EntityFrameworkCore
{
    public class EntityFrameworkCoreCattleTrackDbSchemaMigrator
        : ICattleTrackDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreCattleTrackDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the CattleTrackMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<CattleTrackMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}