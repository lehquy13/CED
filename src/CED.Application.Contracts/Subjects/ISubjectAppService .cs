using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CED.Subjects
{
    public interface ISubjectAppService :
    ICrudAppService< //Defines CRUD methods
        SubjectDto, //Used to show Subject
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateSubjectDto> //Used to create/update a Subject
    {


    }
}
