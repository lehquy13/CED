using CED.Subjects;
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace CED
{
    public class SubjectDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Subject, Guid> _subjectRepository;

        public SubjectDataSeederContributor(IRepository<Subject, Guid> subjectRepository)
        {
            this._subjectRepository = subjectRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _subjectRepository.GetCountAsync() <= 0)
            {
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Maths"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Programing"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Psychology"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "English"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Vietnamese"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Korean"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "German"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Russian"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "French"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Mandarin"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Chemistry"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Physics"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Chemistry"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Biology"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Information technology"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Algebra"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Geometry"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Geography"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Literature"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Martial Art"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Guitar"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Design"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                new Subject
                {
                    Name = "Visual Art"
                },
                autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Music"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Singing"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Statistic"
                    },
                    autoSave: true
                );
                await _subjectRepository.InsertAsync(
                    new Subject
                    {
                        Name = "Others"
                    },
                    autoSave: true
                );
            }
        }


    }
}