using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using CED.ClassInformations;


namespace CED.Web.Pages.ClassInformations
{
    public class CreateModel : CEDPageModel
    {
        [BindProperty]
        public CreateUpdateClassInformationDto ClassInformation { get; set; }
        

        private readonly IClassInformationAppService _ClassInformationAppService;

        public CreateModel(IClassInformationAppService bookAppService)
        {
            _ClassInformationAppService = bookAppService;
        }

        public void OnGet()
        {
            ClassInformation = new CreateUpdateClassInformationDto();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _ClassInformationAppService.CreateAsync(ClassInformation);
            return NoContent();
        }
    }
}

