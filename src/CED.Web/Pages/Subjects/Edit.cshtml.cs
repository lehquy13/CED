using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CED.Subjects;

namespace CED.Web.Pages.Subjects
{
    public class EditModel : CEDPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateSubjectDto Subject { get; set; }

        private readonly ISubjectAppService _subjectAppService;

        public EditModel(ISubjectAppService bookAppService)
        {
            _subjectAppService = bookAppService;
        }

        public async Task OnGetAsync()
        {
            var subjectDto = await _subjectAppService.GetAsync(Id);
            Subject = ObjectMapper.Map<SubjectDto, CreateUpdateSubjectDto>(subjectDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _subjectAppService.UpdateAsync(Id, Subject);
            return NoContent();
        }

      
    }
}
