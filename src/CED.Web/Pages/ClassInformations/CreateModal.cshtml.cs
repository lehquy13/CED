using CED.ClassInformations;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CED.Web.Pages.ClassInformations
{
    public class CreateModalModel : CEDPageModel
    {
        [BindProperty]
        public CreateUpdateClassInformationDto ClassInformation { get; set; }

        private readonly IClassInformationAppService _ClassInformationAppService;

        public CreateModalModel(IClassInformationAppService bookAppService)
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
