﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CED.ClassInformations
{
	public class CreateUpdateSubjectDto : AuditedEntityDto<Guid>
	{
		public string Name { get; set; }
	}
}