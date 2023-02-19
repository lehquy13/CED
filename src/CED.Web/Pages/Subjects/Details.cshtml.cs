using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CED.ClassInformations;
using CED.EntityFrameworkCore;

namespace CED.Web.Pages.Subjects
{
    public class DetailsModel : PageModel
    {
        private readonly CED.EntityFrameworkCore.CEDDbContext _context;

        public DetailsModel(CED.EntityFrameworkCore.CEDDbContext context)
        {
            _context = context;
        }

      public Subject Subject { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Subjects == null)
            {
                return NotFound();
            }

            var subject = await _context.Subjects.FirstOrDefaultAsync(m => m.Id == id);
            if (subject == null)
            {
                return NotFound();
            }
            else 
            {
                Subject = subject;
            }
            return Page();
        }
    }
}
