using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Pdf.Demo.EntityFrameworkCore
{
    public static class DemoDbContextModelCreatingExtensions
    {
        public static void ConfigureDemo(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(DemoConsts.DbTablePrefix + "YourEntities", DemoConsts.DbSchema);

            //    //...
            //});
        }
    }
}