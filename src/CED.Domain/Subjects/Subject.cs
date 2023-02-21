using System;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace CED.Subjects
{
    public class Subject : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; private set; }
        private Subject()
        {
            /* This constructor is for deserialization / ORM purpose */
        }
        internal Subject(
        Guid id,
        [NotNull] string name)
        : base(id)
        {
            SetName(name);
        }
        internal Subject ChangeName([NotNull] string name)
        {
            SetName(name);
            return this;
        }
        private void SetName([NotNull] string name)
        {
            Name = Check.NotNullOrWhiteSpace(
                name,
                nameof(name),
                maxLength:SubjectConsts.MaxNameLength
            );
        }
    }
}
