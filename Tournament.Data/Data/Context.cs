using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tournament.Core.Entities;

namespace Tournament.Data.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Tournament.Core.Entities.Tournament> Tournament { get; set; } = default!;
        public DbSet<Tournament.Core.Entities.Game> Game { get; set; } = default!;
    }
}
