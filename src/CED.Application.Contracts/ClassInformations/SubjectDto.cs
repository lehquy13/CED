﻿using System;
using Volo.Abp.Application.Dtos;

namespace CED.ClassInformations
{
	public class SubjectDto : AuditedEntityDto<Guid>
	{
		public string Name { get; set; }
	}
}
