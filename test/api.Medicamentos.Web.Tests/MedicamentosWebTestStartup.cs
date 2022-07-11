using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace api.Medicamentos;

public class MedicamentosWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<MedicamentosWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
