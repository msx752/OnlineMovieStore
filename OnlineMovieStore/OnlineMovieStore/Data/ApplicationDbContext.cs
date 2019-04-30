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
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasKey(f => f.Id);
            modelBuilder.Entity<Rating>().HasKey(f => f.Id);
            modelBuilder.Entity<Category>().HasKey(f => f.Id);
            modelBuilder.Entity<MovieCategory>().HasKey(f => f.Id);

            modelBuilder.Entity<Movie>()
              .HasOne<Rating>(s => s.Rating)
              .WithMany(g => g.Movies)
              .HasForeignKey(s => s.RatingId);

            modelBuilder.Entity<MovieCategory>()
             .HasOne<Movie>(s => s.Movie)
             .WithMany(g => g.Categories)
             .HasForeignKey(s => s.MovieId);

            modelBuilder.Entity<MovieCategory>()
             .HasOne<Category>(s => s.Category)
             .WithMany(g => g.Categories)
             .HasForeignKey(s => s.CategoryId);

            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

    }
}
