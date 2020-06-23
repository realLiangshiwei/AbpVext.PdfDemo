using Pdf.Demo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Pdf.Demo
{
    [DependsOn(
        typeof(DemoEntityFrameworkCoreTestModule)
        )]
    public class DemoDomainTestModule : AbpModule
    {

    }
}