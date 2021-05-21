using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Logistic_Company.Data;
using Logistic_Company.Models;

namespace Logistic_Company.Pages.sotrudnic_
{
    public class IndexModel : PageModel
    {
        private readonly Logistic_Company.Data.Logistic_CompanyContext _context;

        public IndexModel(Logistic_Company.Data.Logistic_CompanyContext context)
        {
            _context = context;
        }

        public IList<sotrudnic> sotrudnic { get;set; }

        public async Task OnGetAsync()
        {
            sotrudnic = await _context.sotrudnic.ToListAsync();
        }
    }
}
