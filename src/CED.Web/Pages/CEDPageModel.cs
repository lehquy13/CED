using CED.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CED.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class CEDPageModel : AbpPageModel
{
    protected CEDPageModel()
    {
        LocalizationResourceType = typeof(CEDResource);
    }
}
