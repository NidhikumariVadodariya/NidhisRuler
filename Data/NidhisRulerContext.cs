using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NidhisRuler.Models;

namespace NidhisRuler.Data
{
    public class NidhisRulerContext : DbContext
    {
        public NidhisRulerContext(DbContextOptions<NidhisRulerContext> options)
            : base(options)
        {
        }

        public DbSet<Ruler> Ruler { get; set; }
    }
}
