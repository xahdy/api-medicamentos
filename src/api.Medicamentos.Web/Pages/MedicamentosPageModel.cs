using api.Medicamentos.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace api.Medicamentos.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class MedicamentosPageModel : AbpPageModel
{
    protected MedicamentosPageModel()
    {
        LocalizationResourceType = typeof(MedicamentosResource);
    }
}
