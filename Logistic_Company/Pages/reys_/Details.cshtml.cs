using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Logistic_Company.Data;
using Logistic_Company.Models;

namespace Logistic_Company.Pages.reys_
{
    public class DetailsModel : PageModel
    {
        private readonly Logistic_Company.Data.Logistic_CompanyContext _context;

        public DetailsModel(Logistic_Company.Data.Logistic_CompanyContext context)
        {
            _context = context;
        }

        public reys reys { get; set; }

        public async Task<IActionResult> OnGetAsync(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            reys = await _context.reys.FirstOrDefaultAsync(m => m.ID == id);

            if (reys == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
