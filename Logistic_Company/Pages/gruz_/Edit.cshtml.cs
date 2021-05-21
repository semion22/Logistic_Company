using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Logistic_Company.Data;
using Logistic_Company.Models;

namespace Logistic_Company.Pages.gruz_
{
    public class EditModel : PageModel
    {
        private readonly Logistic_Company.Data.Logistic_CompanyContext _context;

        public EditModel(Logistic_Company.Data.Logistic_CompanyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public gruz gruz { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            gruz = await _context.gruz.FirstOrDefaultAsync(m => m.ID == id);

            if (gruz == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(gruz).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!gruzExists(gruz.ID))
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

        private bool gruzExists(string id)
        {
            return _context.gruz.Any(e => e.ID == id);
        }
    }
}
