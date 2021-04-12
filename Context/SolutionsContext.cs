using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Solutions4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solutions4.Context
{
    public class SolutionsContext : IdentityDbContext
    {
        public SolutionsContext(DbContextOptions<SolutionsContext>options)
            : base(options) { }

        public DbSet<Patente> Patentes { get; set; }

    }
}
