using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace CED.ClassInformations
{
	public class AvailableDate : AuditedAggregateRoot<Guid>
	{
		public DayOfWeek DayOfWeek { get; set; }
		public int BeginTime{ get; set; }
		public int EndTime { get; set; }

	}
}
