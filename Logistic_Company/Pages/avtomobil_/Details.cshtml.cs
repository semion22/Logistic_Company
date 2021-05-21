using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Logistic_Company.Data;
using Logistic_Company.Models;

namespace Logistic_Company.Pages.avtomobil_
{
    public class DetailsModel : PageModel
    {
        private readonly Logistic_Company.Data.Logistic_CompanyContext _context;

        public DetailsModel(Logistic_Company.Data.Logistic_CompanyContext context)
        {
            _context = context;
        }

        public avtomobil avtomobil { get; set; }

        public async Task<IActionResult> OnGetAsync(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            avtomobil = await _context.avtomobil.FirstOrDefaultAsync(m => m.ID == id);

            if (avtomobil == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
