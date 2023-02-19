using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CED.ClassInformations;
using CED.EntityFrameworkCore;

namespace CED.Web.Pages.Subjects
{
    public class CreateModel : CEDPageModel
    {
        [BindProperty]
        public CreateUpdateSubjectDto Subject { get; set; }

        private readonly ISubjectAppService _subjectAppService;

        public CreateModel(ISubjectAppService bookAppService)
        {
            _subjectAppService = bookAppService;
        }

        public void OnGet()
        {
            Subject = new CreateUpdateSubjectDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _subjectAppService.CreateAsync(Subject);
            // return NoContent();
            return RedirectToPage("./Index");

        }

    }
}
