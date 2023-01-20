using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PatronesDeDiseno.Models;

namespace PatronesDeDiseno.Data
{
    public class PatronesDeDisenoContext : DbContext
    {
        public PatronesDeDisenoContext (DbContextOptions<PatronesDeDisenoContext> options)
            : base(options)
        {
        }

        public DbSet<PatronesDeDiseno.Models.Category> Category { get; set; } = default!;

        public DbSet<PatronesDeDiseno.Models.Product> Product { get; set; }
    }
}
