using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Logistic_Company.Data;
using Logistic_Company.Models;

namespace Logistic_Company.Pages.marki_avtomobilua_
{
    public class DetailsModel : PageModel
    {
        private readonly Logistic_Company.Data.Logistic_CompanyContext _context;

        public DetailsModel(Logistic_Company.Data.Logistic_CompanyContext context)
        {
            _context = context;
        }

        public marki_avtomobilua marki_avtomobilua { get; set; }

        public async Task<IActionResult> OnGetAsync(DateTime? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            marki_avtomobilua = await _context.marki_avtomobilua.FirstOrDefaultAsync(m => m.ID == id);

            if (marki_avtomobilua == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
