using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CED.ClassInformations;
using CED.EntityFrameworkCore;

namespace CED.Web.Pages.ClassInformations
{
    public class DeleteModel : PageModel
    {
        private readonly CED.EntityFrameworkCore.CEDDbContext _context;

        public DeleteModel(CED.EntityFrameworkCore.CEDDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public ClassInformation ClassInformation { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.ClassInformations == null)
            {
                return NotFound();
            }

            var classinformation = await _context.ClassInformations.FirstOrDefaultAsync(m => m.Id == id);

            if (classinformation == null)
            {
                return NotFound();
            }
            else 
            {
                ClassInformation = classinformation;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.ClassInformations == null)
            {
                return NotFound();
            }
            var classinformation = await _context.ClassInformations.FindAsync(id);

            if (classinformation != null)
            {
                ClassInformation = classinformation;
                _context.ClassInformations.Remove(ClassInformation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
