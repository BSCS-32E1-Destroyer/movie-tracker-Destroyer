using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using movie_tracker.Models;

namespace movie_tracker.Data
{
    public class movie_trackerContext : DbContext
    {
        public movie_trackerContext (DbContextOptions<movie_trackerContext> options)
            : base(options)
        {
        }

        public DbSet<movie_tracker.Models.Movie> Movie { get; set; } = default!;
    }
}
