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
	public class SubjectAppService :
	CrudAppService< //Defines CRUD methods
		Subject,
		SubjectDto, //Used to show Subject
		Guid, //Primary key of the book entity
		PagedAndSortedResultRequestDto, //Used for paging/sorting
		CreateUpdateSubjectDto>, //Used to create/update a Subject
		ISubjectAppService // implement the ISubjectAppService
	{
		public SubjectAppService(IRepository<Subject, Guid> repository) 
			: base(repository)
		{
		}
	}
}
