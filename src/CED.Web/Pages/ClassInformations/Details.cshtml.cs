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
    public class DetailsModel : PageModel
    {
        private readonly CED.EntityFrameworkCore.CEDDbContext _context;

        public DetailsModel(CED.EntityFrameworkCore.CEDDbContext context)
        {
            _context = context;
        }

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
    }
}
