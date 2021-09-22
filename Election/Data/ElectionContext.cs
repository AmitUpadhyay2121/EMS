using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Election.Data;

namespace Election.Data
{
    public class ElectionContext : DbContext
    {
        public ElectionContext (DbContextOptions<ElectionContext> options)
            : base(options)
        {
        }

        public DbSet<Election.Data.Candidate> Candidate { get; set; }

        public DbSet<Election.Data.Vote> Vote { get; set; }
    }
}
