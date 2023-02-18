using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace CED.ClassInformations
{
	public class Subject : AuditedAggregateRoot<Guid>
	{
		public string Name { get; set; }
	}
}
