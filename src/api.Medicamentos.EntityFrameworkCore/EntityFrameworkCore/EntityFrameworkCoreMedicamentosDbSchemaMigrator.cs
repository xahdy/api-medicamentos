using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using api.Medicamentos.Data;
using Volo.Abp.DependencyInjection;

namespace api.Medicamentos.EntityFrameworkCore;

public class EntityFrameworkCoreMedicamentosDbSchemaMigrator
    : IMedicamentosDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMedicamentosDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the MedicamentosDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MedicamentosDbContext>()
            .Database
            .MigrateAsync();
    }
}
