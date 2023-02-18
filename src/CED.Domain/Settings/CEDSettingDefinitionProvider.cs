using Volo.Abp.Settings;

namespace CED.Settings;

public class CEDSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CEDSettings.MySetting1));
    }
}
