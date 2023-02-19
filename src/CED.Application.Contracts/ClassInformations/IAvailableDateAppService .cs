using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CED.ClassInformations
{
	public interface IAvailableDateAppService :
	ICrudAppService< //Defines CRUD methods
		AvailableDateDto, //Used to show AvailableDate
		Guid, //Primary key of the book entity
		PagedAndSortedResultRequestDto, //Used for paging/sorting
		CreateUpdateAvailableDateDto> //Used to create/update a AvailableDate
	{


	}
}
