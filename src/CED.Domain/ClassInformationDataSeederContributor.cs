using CED.ClassInformations;
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
		private readonly IRepository<ClassInformation, Guid> _subjectRepository;

		public ClassInformationDataSeederContributor	(IRepository<ClassInformation, Guid> subjectRepository)
		{
			this._subjectRepository = subjectRepository;
		}

		public async Task SeedAsync(DataSeedContext context)
		{
			if (await _subjectRepository.GetCountAsync() <= 0)
			{
				
				await _subjectRepository.InsertAsync(
					new ClassInformation
                    {
						Title = "Sample Title",
						Description = "Sample Description",
						Status = Status.Confirmed,
                        LearningMode = LearningMode.Hybrid,
                        GenderRequirement = GenderRequirement.None,
                        AcademicLevel = AcademicLevel.Optional,
                        StudentGender = Gender.Male,
                        Address = "Sample Address",
					},
					autoSave: true
				);
			}
		}


	}
}