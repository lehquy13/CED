using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CED.ClassInformations
{
	public class ClassInformationAppService :
	CrudAppService< //Defines CRUD methods
		ClassInformation,
		ClassInformationDto, //Used to show ClassInformation
		Guid, //Primary key of the book entity
		PagedAndSortedResultRequestDto, //Used for paging/sorting
		CreateUpdateClassInformationDto>, //Used to create/update a ClassInformation
		IClassInformationAppService // implement the IClassInformationAppService
	{
		public ClassInformationAppService(IRepository<ClassInformation, Guid> repository) 
			: base(repository)
		{
		}
	}
}
