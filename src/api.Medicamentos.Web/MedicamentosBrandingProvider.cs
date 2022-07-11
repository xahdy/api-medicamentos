using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace api.Medicamentos.Web;

[Dependency(ReplaceServices = true)]
public class MedicamentosBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Medicamentos";
}
