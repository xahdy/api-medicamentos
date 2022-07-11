using System;
using System.Collections.Generic;
using System.Text;
using api.Medicamentos.Localization;
using Volo.Abp.Application.Services;

namespace api.Medicamentos;

/* Inherit your application services from this class.
 */
public abstract class MedicamentosAppService : ApplicationService
{
    protected MedicamentosAppService()
    {
        LocalizationResource = typeof(MedicamentosResource);
    }
}
