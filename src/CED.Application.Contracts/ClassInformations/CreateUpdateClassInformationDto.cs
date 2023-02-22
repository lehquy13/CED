using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;
using Volo.Abp.MultiTenancy;

namespace CED.ClassInformations
{
	public class CreateUpdateClassInformationDto 
	{
		[Required]
		[StringLength(128)]
		public string Title { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		public Status Status { get; set; } = Status.Waiting;

		[Required]
		public LearningMode LearningMode { get; set; } = LearningMode.Offline;

		[Required]
		public float Fee { get; set; }
		[Required]
		public float ChargeFee { get; set; }

		//Tutor related information
		[Required]
		public GenderRequirement GenderRequirement { get; set; } = GenderRequirement.None;
		[Required]
		public AcademicLevel AcademicLevel { get; set; } = AcademicLevel.Optional;

		//Student related information
		[Required]
		public Gender StudentGender { get; set; } = Gender.Male;
		[Required]
		public int NumberOfStudent { get; set; }

		// Time related information
		[Required]
		public int MinutePerSession { get; set; }
		[Required]
		public int SessionPerWeek { get; set; }

        //[Required]
        //public List<AvailableDateDto> AvailableDates { get; set; }

		// Address related information
		[Required]
		public string Address { get; set; }

        //Subject related information
        //public SubjectDto Subject { get; set; }
        [Required]
        public Guid SubjectId { get; set; }
    }
}
