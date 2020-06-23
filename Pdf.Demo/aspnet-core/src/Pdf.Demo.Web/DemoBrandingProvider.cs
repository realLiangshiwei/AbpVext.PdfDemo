using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Pdf.Demo.Web
{
    [Dependency(ReplaceServices = true)]
    public class DemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Demo";
    }
}
