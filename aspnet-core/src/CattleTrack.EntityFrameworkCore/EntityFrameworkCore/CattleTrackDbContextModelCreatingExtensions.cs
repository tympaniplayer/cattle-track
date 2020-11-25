using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace CattleTrack.EntityFrameworkCore
{
    public static class CattleTrackDbContextModelCreatingExtensions
    {
        public static void ConfigureCattleTrack(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(CattleTrackConsts.DbTablePrefix + "YourEntities", CattleTrackConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}