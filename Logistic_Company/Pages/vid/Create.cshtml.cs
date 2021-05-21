using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Logistic_Company.Data;
using Logistic_Company.Models;

namespace Logistic_Company.Pages.Vid_gruzov_
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
        public Vid_gruzov Vid_gruzov { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Vid_gruzov.Add(Vid_gruzov);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
