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

namespace Logistic_Company.Pages.marki_avtomobilua_
{
    public class EditModel : PageModel
    {
        private readonly Logistic_Company.Data.Logistic_CompanyContext _context;

        public EditModel(Logistic_Company.Data.Logistic_CompanyContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(marki_avtomobilua).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!marki_avtomobiluaExists(marki_avtomobilua.ID))
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

        private bool marki_avtomobiluaExists(DateTime id)
        {
            return _context.marki_avtomobilua.Any(e => e.ID == id);
        }
    }
}
