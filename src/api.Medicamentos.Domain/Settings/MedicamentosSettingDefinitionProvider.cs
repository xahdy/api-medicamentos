using Volo.Abp.Settings;

namespace api.Medicamentos.Settings;

public class MedicamentosSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MedicamentosSettings.MySetting1));
    }
}
