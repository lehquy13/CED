using System;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace CED.Subjects
{
    public class Subject : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
     
    }
}
