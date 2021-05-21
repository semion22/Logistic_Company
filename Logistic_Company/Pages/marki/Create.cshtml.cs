using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Logistic_Company.Data;
using Logistic_Company.Models;

namespace Logistic_Company.Pages.marki_avtomobilua_
{
    public class CreateModel : PageModel
    {
        private readonly Logistic_Company.Data.Logistic_CompanyContext _context;

        public CreateModel(Logistic_Company.Data.Logistic_CompanyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public marki_avtomobilua marki_avtomobilua { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.marki_avtomobilua.Add(marki_avtomobilua);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
