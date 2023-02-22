using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CED.ClassInformations
{
    public interface IClassInformationAppService :
	ICrudAppService< //Defines CRUD methods
		ClassInformationDto, //Used to show ClassInformation
		Guid, //Primary key of the book entity
		PagedAndSortedResultRequestDto, //Used for paging/sorting
		CreateUpdateClassInformationDto> //Used to create/update a ClassInformation
	{
        Task<ListResultDto<SubjectLookupDto>> GetSubjectLookupAsync();

    }
}
