using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Logistic_Company.Models;

namespace Logistic_Company.Data
{
    public class Logistic_CompanyContext : DbContext
    {
        public Logistic_CompanyContext (DbContextOptions<Logistic_CompanyContext> options)
            : base(options)
        {
        }

        public DbSet<Logistic_Company.Models.avtomobil> avtomobil { get; set; }
    }
}
