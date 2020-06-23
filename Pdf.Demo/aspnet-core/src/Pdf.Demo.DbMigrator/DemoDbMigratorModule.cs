using Pdf.Demo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Pdf.Demo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(DemoEntityFrameworkCoreDbMigrationsModule),
        typeof(DemoApplicationContractsModule)
        )]
    public class DemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
