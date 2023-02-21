using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Xunit;

namespace CED.ClassInformations
{
    public class SubjectAppService_Tests : CEDApplicationTestBase
    {
        private readonly ISubjectAppService _subjectAppService;

        public SubjectAppService_Tests()
        {
            _subjectAppService = GetRequiredService<ISubjectAppService>();
        }

        [Fact]
        public async Task Should_Get_List_Of_Class()
        {
            //Act
            var result = await _subjectAppService.GetListAsync(
                new PagedAndSortedResultRequestDto()
            );

            //Assert
            result.TotalCount.ShouldBeGreaterThan(0);
            //result.Items.ShouldContain(b => b. == "1984");
        }
    }
}
