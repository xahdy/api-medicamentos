using System.Threading.Tasks;

namespace api.Medicamentos.Data;

public interface IMedicamentosDbSchemaMigrator
{
    Task MigrateAsync();
}
