using System;
using System.Threading.Tasks;
using CED.ClassInformations;
using Microsoft.AspNetCore.Mvc;


namespace CED.Web.Pages.ClassInformations
{
    public class EditModalModel : CEDPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateClassInformationDto ClassInformation { get; set; }

        private readonly IClassInformationAppService _classInformationAppService;

        public EditModalModel(IClassInformationAppService bookAppService)
        {
            _classInformationAppService = bookAppService;
        }

       
        public async Task OnGetAsync()
        {
            var ClassInformationDto = await _classInformationAppService.GetAsync(Id);
            ClassInformation = ObjectMapper
                .Map<ClassInformationDto, CreateUpdateClassInformationDto>(ClassInformationDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _classInformationAppService.UpdateAsync(Id, ClassInformation);
            return NoContent();
        }
    }
}
