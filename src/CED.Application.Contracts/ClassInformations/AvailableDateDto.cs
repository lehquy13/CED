using System;
using Volo.Abp.Application.Dtos;

namespace CED.ClassInformations
{
	public class AvailableDateDto : AuditedEntityDto<Guid>
	{
		public DayOfWeek DayOfWeek { get; set; }
		public int BeginTime{ get; set; }
		public int EndTime { get; set; }

	}
}
