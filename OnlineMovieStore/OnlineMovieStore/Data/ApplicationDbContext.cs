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
        public DbSet<PaymentHistory> Payments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<MovieWriter> MovieWriters { get; set; }//for many to many relations
        public DbSet<MovieDirector> MovieDirectors { get; set; }//for many to many relations
        public DbSet<MovieCategory> MovieCategories { get; set; }//for many to many relations 
        public DbSet<Basket> Baskets { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
         
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rating>().HasKey(f => f.Id);
            modelBuilder.Entity<Category>().HasKey(f => f.Id);
            modelBuilder.Entity<Writer>().HasKey(f => f.Id);
            modelBuilder.Entity<Director>().HasKey(f => f.Id);

            // one to many
            modelBuilder.Entity<Movie>().HasKey(f => f.Id);
            modelBuilder.Entity<Movie>()
              .HasOne<Rating>(s => s.Rating)
              .WithMany(g => g.Movies)
              .HasForeignKey(s => s.RatingId);

            // many to many 
            modelBuilder.Entity<MovieCategory>().HasKey(f => new { f.MovieId, f.CategoryId });
            modelBuilder.Entity<MovieCategory>()
              .HasOne<Movie>(s => s.Movie)
              .WithMany(g => g.Categories)
              .HasForeignKey(s => s.MovieId);
            modelBuilder.Entity<MovieCategory>()
             .HasOne<Category>(s => s.Category)
             .WithMany(g => g.Categories)
             .HasForeignKey(s => s.CategoryId);

            //

            // many to many 
            modelBuilder.Entity<MovieDirector>().HasKey(f => new { f.MovieId, f.DirectorId });
            modelBuilder.Entity<MovieDirector>()
              .HasOne<Movie>(s => s.Movie)
              .WithMany(g => g.MovieDirectors)
              .HasForeignKey(s => s.MovieId);
            modelBuilder.Entity<MovieDirector>()
             .HasOne<Director>(s => s.Director)
             .WithMany(g => g.MovieDirectors)
             .HasForeignKey(s => s.DirectorId);
            //

            // many to many 
            modelBuilder.Entity<MovieWriter>().HasKey(f => new { f.MovieId, f.WriterId });
            modelBuilder.Entity<MovieWriter>()
              .HasOne<Movie>(s => s.Movie)
              .WithMany(g => g.MovieWriters)
              .HasForeignKey(s => s.MovieId);
            modelBuilder.Entity<MovieWriter>()
             .HasOne<Writer>(s => s.Writer)
             .WithMany(g => g.MovieWriters)
             .HasForeignKey(s => s.WriterId);
            //

            // many to many 
            modelBuilder.Entity<PaymentHistory>().HasKey(f => new { f.MovieId, f.UserId });
            modelBuilder.Entity<PaymentHistory>()
              .HasOne<Movie>(s => s.Movie)
              .WithMany(g => g.PaymentHistory)
              .HasForeignKey(s => s.MovieId);
            modelBuilder.Entity<PaymentHistory>()
             .HasOne<User>(s => s.User)
             .WithMany(g => g.PaymentHistory)
             .HasForeignKey(s => s.UserId);

            //
            modelBuilder.SeedCategories();
            modelBuilder.SeedDirectors();
            modelBuilder.SeedWriters();
            modelBuilder.SeedRatings();
            modelBuilder.SeedMovies();
            modelBuilder.SeedMovieWriters();
            modelBuilder.SeedmovieDirectors();
            modelBuilder.SeedMovieCategories();
            base.OnModelCreating(modelBuilder);
        }

    }
}
