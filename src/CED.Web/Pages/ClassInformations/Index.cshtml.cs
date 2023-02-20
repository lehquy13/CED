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
    public class IndexModel : PageModel
    {
        private readonly CED.EntityFrameworkCore.CEDDbContext _context;

        public IndexModel(CED.EntityFrameworkCore.CEDDbContext context)
        {
            _context = context;
        }

        public IList<ClassInformation> ClassInformation { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ClassInformations != null)
            {
                ClassInformation = await _context.ClassInformations.ToListAsync();
            }
        }
    }
}
