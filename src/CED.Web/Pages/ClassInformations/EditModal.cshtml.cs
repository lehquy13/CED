using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Threading.Tasks;
using CED.ClassInformations;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace CED.Web.Pages.ClassInformations
{
    public class EditModalModel : CEDPageModel
    {

        [BindProperty]
        public EditClassInformationViewModel ClassInformation { get; set; }

        public List<SelectListItem> Subjects { get; set; }

        private readonly IClassInformationAppService _classInformationAppService;

        public EditModalModel(IClassInformationAppService bookAppService)
        {
            _classInformationAppService = bookAppService;
        }


        public async Task OnGetAsync(Guid id)
        {
            var ClassInformationDto = await _classInformationAppService.GetAsync(id);
            ClassInformation = ObjectMapper
                .Map<ClassInformationDto, EditClassInformationViewModel>(ClassInformationDto);


            var subjectLookup = await _classInformationAppService.GetSubjectLookupAsync();
            Subjects = subjectLookup.Items
                .Select(x => new SelectListItem(x.Name, x.Id.ToString()))
                .ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _classInformationAppService
                .UpdateAsync(ClassInformation.Id,
                            ObjectMapper
                                .Map<EditClassInformationViewModel, CreateUpdateClassInformationDto>(ClassInformation)
            );
            return NoContent();
        }

        public class EditClassInformationViewModel
        {
            [HiddenInput]
            public Guid Id { get; set; }

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
