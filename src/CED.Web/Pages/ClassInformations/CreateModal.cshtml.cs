using CED.ClassInformations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Volo.Abp.ObjectMapping;

namespace CED.Web.Pages.ClassInformations
{
    public class CreateModalModel : CEDPageModel
    {

        [BindProperty]
        public CreateClassInformationViewModel ClassInformation { get; set; }
        public List<SelectListItem> Subjects { get; set; }

        private readonly IClassInformationAppService _classInformationAppService;

        public CreateModalModel(IClassInformationAppService classInformationAppService)
        {
            _classInformationAppService = classInformationAppService;
        }

        public async Task OnGet()
        {
            ClassInformation = new CreateClassInformationViewModel();

            var subjectLookup = await _classInformationAppService.GetSubjectLookupAsync();
            Subjects = subjectLookup.Items
                .Select(x => new SelectListItem(x.Name, x.Id.ToString()))
                .ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            await _classInformationAppService
                .CreateAsync(
                ObjectMapper.Map<CreateClassInformationViewModel, CreateUpdateClassInformationDto>(ClassInformation)
            );
            return NoContent();
        }

        public class CreateClassInformationViewModel
        {
            [SelectItems(nameof(Subjects))]
            [DisplayName("Subject")]
            public Guid SubjectId { get; set; }

            //[Required]
            //[StringLength(128)]
            //public string Name { get; set; }

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
        }
    }
}
