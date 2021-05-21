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

        public DbSet<Logistic_Company.Models.dilznost> dilznost { get; set; }

        public DbSet<Logistic_Company.Models.gruz> gruz { get; set; }

        public DbSet<Logistic_Company.Models.marki_avtomobilua> marki_avtomobilua { get; set; }

        public DbSet<Logistic_Company.Models.reys> reys { get; set; }

        public DbSet<Logistic_Company.Models.sotrudnic> sotrudnic { get; set; }

        public DbSet<Logistic_Company.Models.vid_avtomobilya> vid_avtomobilya { get; set; }

        public DbSet<Logistic_Company.Models.Vid_gruzov> Vid_gruzov { get; set; }
    }
}
