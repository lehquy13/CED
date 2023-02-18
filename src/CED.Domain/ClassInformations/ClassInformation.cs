using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace CED.ClassInformations
{
	public class ClassInformation : AuditedAggregateRoot<Guid>
	{
		public string Title { get; set; } 
		public string Description { get; set; } 
		public Status Status { get; set; } 
		public LearningMode LearningFormality { get; set; }

		public float Fee { get; set; } 
		public float ChargeFee { get; set; }

		//Tutor related information
		public GenderRequirement GenderRequirement { get; set; }
		public AcademicLevel AcademicLevel { get; set; }

		//Student related information
		public Gender StudentGender { get; set; }
		public int NumberOfStudent { get; set; }

		// Time related information
		public int MinutePerSession { get; set; }
		public int SessionPerWeek { get; set; }
		public List<AvailableDate> AvailableDates { get; set; }

		// Address related information
		public string Address { get; set; }

		//Subject related information
		public Subject Subject { get; set; }

	}
}
