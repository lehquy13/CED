using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CED.Web;

[Dependency(ReplaceServices = true)]
public class CEDBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CED";
}
