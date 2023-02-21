using System;

using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Services;

using JetBrains.Annotations;

namespace CED.Subjects
{
    internal class SubjectManager : DomainService
    {
        private readonly ISubjectRepository _authorRepository;

        public SubjectManager(ISubjectRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<Subject> CreateAsync(
            [NotNull] string name,
            DateTime birthDate,
            [CanBeNull] string shortBio = null)
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));

            var existingSubject = await _authorRepository.FindByNameAsync(name);
            if (existingSubject != null)
            {
                throw new SubjectAlreadyExistsException(name);
            }

            return new Subject(
                GuidGenerator.Create(),
                name
            );
        }

        public async Task ChangeNameAsync(
            [NotNull] Subject subject,
            [NotNull] string newName)
        {
            Check.NotNull(subject, nameof(subject));
            Check.NotNullOrWhiteSpace(newName, nameof(newName));

            var existingAuthor = await _authorRepository.FindByNameAsync(newName);
            if (existingAuthor != null && existingAuthor.Id != subject.Id)
            {
                throw new SubjectAlreadyExistsException(newName);
            }

            subject.ChangeName(newName);
        }
    }
}
