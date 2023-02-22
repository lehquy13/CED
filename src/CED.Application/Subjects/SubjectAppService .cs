using CED.Permissions;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CED.Subjects
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
            GetPolicyName = CEDPermissions.Subject.Default;
            GetListPolicyName = CEDPermissions.Subject.Default;
            CreatePolicyName = CEDPermissions.Subject.Create;
            UpdatePolicyName = CEDPermissions.Subject.Edit;
            DeletePolicyName = CEDPermissions.Subject.Delete;
        }
    }
}
