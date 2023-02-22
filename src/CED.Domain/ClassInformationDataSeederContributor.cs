using CED.ClassInformations;
using CED.Subjects;
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace CED
{
    public class ClassInformationDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<ClassInformation, Guid> _classInformationRepository;
        private readonly IRepository<Subject, Guid> _subjectRepository;

        public ClassInformationDataSeederContributor(
            IRepository<ClassInformation, Guid> classInformationRepository,
            IRepository<Subject, Guid> subjectRepository

            )
        {
            this._subjectRepository= subjectRepository;
            this._classInformationRepository = classInformationRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            var orwell = await _subjectRepository
                .InsertAsync(new Subject() { Name = "Sample Subject For Sample Class"});

            if (await _subjectRepository.GetCountAsync() <= 0)
            {

                await _classInformationRepository.InsertAsync(
                    new ClassInformation
                    {
                        Title = "Sample Title",
                        Description = "Sample Description",
                        Status = Status.Confirmed,
                        LearningMode = LearningMode.Hybrid,
                        GenderRequirement = GenderRequirement.None,
                        AcademicLevel = AcademicLevel.Optional,
                        SubjectId = orwell.Id,
                        StudentGender = Gender.Male,
                        Address = "Sample Address",
                    },
                    autoSave: true
                );
            }
        }


    }
}