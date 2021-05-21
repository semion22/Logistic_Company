using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Logistic_Company.Data;
using Logistic_Company.Models;

namespace Logistic_Company.Pages.Vid_gruzov_
{
    public class DetailsModel : PageModel
    {
        private readonly Logistic_Company.Data.Logistic_CompanyContext _context;

        public DetailsModel(Logistic_Company.Data.Logistic_CompanyContext context)
        {
            _context = context;
        }

        public Vid_gruzov Vid_gruzov { get; set; }

        public async Task<IActionResult> OnGetAsync(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vid_gruzov = await _context.Vid_gruzov.FirstOrDefaultAsync(m => m.ID == id);

            if (Vid_gruzov == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
