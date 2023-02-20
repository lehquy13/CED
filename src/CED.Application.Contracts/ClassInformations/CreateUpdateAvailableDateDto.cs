using System;
using Volo.Abp.Application.Dtos;

namespace CED.ClassInformations
{
	public class CreateUpdateAvailableDateDto 
	{
		public DayOfWeek DayOfWeek { get; set; }
		public int BeginTime{ get; set; }
		public int EndTime { get; set; }

	}
}
