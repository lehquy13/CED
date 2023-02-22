using System;
using Volo.Abp.Application.Dtos;

namespace CED.Subjects
{
    public class SubjectDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
