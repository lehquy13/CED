using CED.Subjects;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;
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
					new Subject(Guid.NewGuid(),"Maths"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "programming"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "C# programming"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Java programming"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "C/C++ programming"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Python programming"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Android programming"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Web programming"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Psychology"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "English"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Vietnamese"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Korean"),
					autoSave: true
				);	
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "German"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Russian"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "French"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Mandarin"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Chemistry"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Physics"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Biology"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Information technology"),
					autoSave: true
				);	
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Algebra"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Geometry"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Geography"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Literature"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Guitar"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Geometry"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Design"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Music"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Singing"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Statistic"),
					autoSave: true
				);
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Others"),
					autoSave: true
				);
			
				await _subjectRepository.InsertAsync(
                    new Subject(Guid.NewGuid(), "Visual Art"),
					autoSave: true
				);
			}
		}


	}
}