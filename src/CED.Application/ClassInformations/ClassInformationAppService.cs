using CED.Permissions;
using CED.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
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
        private readonly IRepository<Subject,Guid> _subjectRepository;
        public ClassInformationAppService(
            IRepository<ClassInformation, Guid> repository, //this is required
            IRepository<Subject, Guid> subjectRepository //this is added for getting list of subjects
            ) 
			: base(repository)
		{
            _subjectRepository = subjectRepository;
            GetPolicyName = CEDPermissions.ClassInformation.Default;
            GetListPolicyName = CEDPermissions.ClassInformation.Default;
            CreatePolicyName = CEDPermissions.ClassInformation.Create;
            UpdatePolicyName = CEDPermissions.ClassInformation.Edit;
            DeletePolicyName = CEDPermissions.ClassInformation.Delete;
        }

        public override async Task<PagedResultDto<ClassInformationDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            //Get the IQueryable<Book> from the repository
            var queryable = await Repository.GetQueryableAsync();

            //Prepare a query to join books and authors
            var query = from classInformation in queryable
                        join subject in await _subjectRepository.GetQueryableAsync() on classInformation.SubjectId equals subject.Id
                        select new { classInformation, subject };

            //Paging
            query = query
                .OrderBy(NormalizeSorting(input.Sorting))
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount);

            //Execute the query and get a list
            var queryResult = await AsyncExecuter.ToListAsync(query);

            //Convert the query result to a list of ClassInformationDto objects
            var classInformationDtos = queryResult.Select(x =>
            {
                var classInformationDto = ObjectMapper.Map<ClassInformation, ClassInformationDto>(x.classInformation);
                classInformationDto.SubjectName = x.subject.Name;
                return classInformationDto;
            }).ToList();

            //Get the total count with another query
            var totalCount = await Repository.GetCountAsync();

            return new PagedResultDto<ClassInformationDto>(
                totalCount,
                classInformationDtos
            );
        }

        public async Task<ListResultDto<SubjectLookupDto>> GetSubjectLookupAsync()
        {
            var authors = await _subjectRepository.GetListAsync();

            return new ListResultDto<SubjectLookupDto>(
                ObjectMapper.Map<List<Subject>, List<SubjectLookupDto>>(authors)
            );
        }

        private static string NormalizeSorting(string sorting)
        {
            if (sorting.IsNullOrEmpty())
            {
                return $"classInformation.{nameof(ClassInformation.Title)}";
            }

            if (sorting.Contains("subjectName", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "subjectName",
                    "subject.Name",
                    StringComparison.OrdinalIgnoreCase
                );
            }

            return $"classInformation.{sorting}";
        }
    }
}
