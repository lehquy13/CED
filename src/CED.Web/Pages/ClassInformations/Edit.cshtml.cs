using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CED.ClassInformations;
using CED.EntityFrameworkCore;

namespace CED.Web.Pages.ClassInformations
{
    public class EditModel : PageModel
    {
        private readonly CED.EntityFrameworkCore.CEDDbContext _context;

        public EditModel(CED.EntityFrameworkCore.CEDDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ClassInformation ClassInformation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.ClassInformations == null)
            {
                return NotFound();
            }

            var classinformation =  await _context.ClassInformations.FirstOrDefaultAsync(m => m.Id == id);
            if (classinformation == null)
            {
                return NotFound();
            }
            ClassInformation = classinformation;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ClassInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassInformationExists(ClassInformation.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ClassInformationExists(Guid id)
        {
          return _context.ClassInformations.Any(e => e.Id == id);
        }
    }
}
