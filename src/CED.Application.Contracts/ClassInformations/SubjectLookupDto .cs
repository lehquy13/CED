using System;
using Volo.Abp.Application.Dtos;

namespace CED.ClassInformations
{
    public class SubjectLookupDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
