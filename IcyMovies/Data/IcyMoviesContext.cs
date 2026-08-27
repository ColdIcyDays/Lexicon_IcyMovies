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
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Review>()
                .HasOne(p => p.TargetMovie)
                .WithMany()
                .HasForeignKey(fk => fk.MovieId);
        }

        public DbSet<IcyMovies.Models.Movie> Movies { get; set; } = default!;
        public DbSet<IcyMovies.Models.Review> Reviews { get; set; } = default!;
    }
}
