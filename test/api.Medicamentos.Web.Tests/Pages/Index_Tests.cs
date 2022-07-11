using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace api.Medicamentos.Pages;

public class Index_Tests : MedicamentosWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
