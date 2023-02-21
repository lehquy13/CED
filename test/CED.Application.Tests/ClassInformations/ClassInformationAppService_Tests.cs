using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Xunit;

namespace CED.ClassInformations
{
    public class ClassInformationAppService_Tests: CEDApplicationTestBase
    {
        private readonly IClassInformationAppService _classInformationAppService;

        public ClassInformationAppService_Tests()
        {
            _classInformationAppService = GetRequiredService<IClassInformationAppService>();
        }

        [Fact]
        public async Task Should_Get_List_Of_Class()
        {
            //Act
            var result = await _classInformationAppService.GetListAsync(
                new PagedAndSortedResultRequestDto()
            );

            //Assert
            result.TotalCount.ShouldBeGreaterThan(0);
            //result.Items.ShouldContain(b => b. == "1984");
        }
    }
}
