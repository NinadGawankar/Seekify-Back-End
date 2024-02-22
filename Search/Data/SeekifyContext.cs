using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Search.Data
{
    public class SeekifyContext : DbContext
    {
        public SeekifyContext (DbContextOptions<SeekifyContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Location> Locations { get; set; } = default!;
    }
}
