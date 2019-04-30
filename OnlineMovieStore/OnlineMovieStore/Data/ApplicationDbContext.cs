using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineMovieStore.Data.Tables;

namespace OnlineMovieStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
              .HasOne<MovieRating>(s => s.Rating)
              .WithMany(g => g.Movies)
              .HasForeignKey(s => s.RatingId);

            modelBuilder.Seed();
        }

    }
}
