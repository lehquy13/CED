using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace CED.Pages;

public class Index_Tests : CEDWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
