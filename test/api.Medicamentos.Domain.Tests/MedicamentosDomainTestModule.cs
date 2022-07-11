using api.Medicamentos.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace api.Medicamentos;

[DependsOn(
    typeof(MedicamentosEntityFrameworkCoreTestModule)
    )]
public class MedicamentosDomainTestModule : AbpModule
{

}
