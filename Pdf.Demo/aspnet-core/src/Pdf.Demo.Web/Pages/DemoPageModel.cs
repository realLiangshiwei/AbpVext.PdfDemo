using Pdf.Demo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Pdf.Demo.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class DemoPageModel : AbpPageModel
    {
        protected DemoPageModel()
        {
            LocalizationResourceType = typeof(DemoResource);
        }
    }
}