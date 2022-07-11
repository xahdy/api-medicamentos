using Volo.Abp.Modularity;

namespace api.Medicamentos;

[DependsOn(
    typeof(MedicamentosApplicationModule),
    typeof(MedicamentosDomainTestModule)
    )]
public class MedicamentosApplicationTestModule : AbpModule
{

}
