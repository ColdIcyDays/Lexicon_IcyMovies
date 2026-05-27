using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IcyMovies.Models;

namespace IcyMovies.Data
{
    public class IcyMoviesContext : DbContext
    {
        public IcyMoviesContext (DbContextOptions<IcyMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<IcyMovies.Models.Movie> Movies { get; set; } = default!;
    }
}
