using api.Medicamentos.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace api.Medicamentos.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MedicamentosEntityFrameworkCoreModule),
    typeof(MedicamentosApplicationContractsModule)
    )]
public class MedicamentosDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
