using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace api.Medicamentos.Data;

/* This is used if database provider does't define
 * IMedicamentosDbSchemaMigrator implementation.
 */
public class NullMedicamentosDbSchemaMigrator : IMedicamentosDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
