using CED.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CED.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CEDController : AbpControllerBase
{
    protected CEDController()
    {
        LocalizationResource = typeof(CEDResource);
    }
}
