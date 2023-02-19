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
	public class AvailableDateAppService :
	CrudAppService< //Defines CRUD methods
		AvailableDate,
		AvailableDateDto, //Used to show AvailableDate
		Guid, //Primary key of the book entity
		PagedAndSortedResultRequestDto, //Used for paging/sorting
		CreateUpdateAvailableDateDto>, //Used to create/update a AvailableDate
		IAvailableDateAppService // implement the IAvailableDateAppService
	{
		public AvailableDateAppService(IRepository<AvailableDate, Guid> repository) 
			: base(repository)
		{
		}
	}
}
