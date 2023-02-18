using System;
using System.Collections.Generic;
using System.Text;
using CED.Localization;
using Volo.Abp.Application.Services;

namespace CED;

/* Inherit your application services from this class.
 */
public abstract class CEDAppService : ApplicationService
{
    protected CEDAppService()
    {
        LocalizationResource = typeof(CEDResource);
    }
}
