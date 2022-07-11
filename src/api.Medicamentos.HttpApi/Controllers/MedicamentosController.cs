using api.Medicamentos.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace api.Medicamentos.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MedicamentosController : AbpControllerBase
{
    protected MedicamentosController()
    {
        LocalizationResource = typeof(MedicamentosResource);
    }
}
