using Microsoft.EntityFrameworkCore;
using OnlineMovieStore.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Data
{

    public static class ModelBuilderExtensions
    {
        public static void SeedWriters(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Writer>().HasData(
            new Writer() { Id = "nm0908624", FullName = "Edgar Wallace" },
            new Writer() { Id = "nm0251912", FullName = "Egon Eis" },
            new Writer() { Id = "nm0525742", FullName = "Wolfgang Lukschy" },
            new Writer() { Id = "nm0173775", FullName = "Lluís Josep Comerón" },
            new Writer() { Id = "nm0905152", FullName = "Lilly Wachowski" },
            new Writer() { Id = "nm0905154", FullName = "Lana Wachowski" },
            new Writer() { Id = "nm0000116", FullName = "James Cameron" },
            new Writer() { Id = "nm0807023", FullName = "Natalia Smirnoff" },
            new Writer() { Id = "nm0150043", FullName = "Ted Chalmers" },
            new Writer() { Id = "nm0827500", FullName = "David S. Sterling" },
            new Writer() { Id = "nm0956913", FullName = "Andrei Zinca" },
            new Writer() { Id = "nm0610219", FullName = "Oren Moverman" },
            new Writer() { Id = "nm0474289", FullName = "Heikki Kujanpää" },
            new Writer() { Id = "nm0718558", FullName = "Mikko Reitala" },
            new Writer() { Id = "nm10086396", FullName = "Bradley Alcime" }
                );

        }

        public static void SeedDirectors(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>().HasData(
                new Director() { Id = "nm0901138", FullName = "Alfred Vohrer" },
                new Director() { Id = "nm0173775", FullName = "Lluís Josep Comerón" },
                new Director() { Id = "nm0905152", FullName = "Lilly Wachowski" },
                new Director() { Id = "nm0905154", FullName = "Lana Wachowski" },
                new Director() { Id = "nm0000116", FullName = "James Cameron" },
                new Director() { Id = "nm0807023", FullName = "Natalia Smirnoff" },
                new Director() { Id = "nm0006955", FullName = "Lewis Schoenbrun" },
                new Director() { Id = "nm0956913", FullName = "Andrei Zinca" },
                new Director() { Id = "nm0474289", FullName = "Heikki Kujanpää" },
                new Director() { Id = "nm10086396", FullName = "Bradley Alcime" },
                new Director() { Id = "nm10114969", FullName = "Ahmed Mansour" }
                );

        }

        public static void SeedmovieDirectors(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieDirector>().HasData(
                new MovieDirector() { Id = 1, MovieId = "tt0054395", DirectorId = "nm0901138" },
                new MovieDirector() { Id = 2, MovieId = "tt0091805", DirectorId = "nm0173775" },
                new MovieDirector() { Id = 3, MovieId = "tt0133093", DirectorId = "nm0905152" },
                new MovieDirector() { Id = 4, MovieId = "tt0133093", DirectorId = "nm0905154" },
                new MovieDirector() { Id = 5, MovieId = "tt0234215", DirectorId = "nm0905154" },
                new MovieDirector() { Id = 6, MovieId = "tt0234215", DirectorId = "nm0905152" },
                new MovieDirector() { Id = 7, MovieId = "tt0499549", DirectorId = "nm0000116" },
                new MovieDirector() { Id = 8, MovieId = "tt1517238", DirectorId = "nm0807023" },
                new MovieDirector() { Id = 9, MovieId = "tt1854506", DirectorId = "nm0006955" },
                new MovieDirector() { Id = 10, MovieId = "tt2076307", DirectorId = "nm0956913" },
                new MovieDirector() { Id = 11, MovieId = "tt7220696", DirectorId = "nm0474289" },
                new MovieDirector() { Id = 12, MovieId = "tt8923874", DirectorId = "nm10086396" },
                new MovieDirector() { Id = 13, MovieId = "tt8984748", DirectorId = "nm10114969" }

                );

        }
        public static void SeedMovieWriters(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieWriter>().HasData(
                new MovieWriter() { Id = 1, MovieId = "tt0054395", WriterId = "nm0908624" },
                new MovieWriter() { Id = 2, MovieId = "tt0054395", WriterId = "nm0251912" },
                new MovieWriter() { Id = 3, MovieId = "tt0054395", WriterId = "nm0525742" },
                new MovieWriter() { Id = 4, MovieId = "tt0091805", WriterId = "nm0173775" },
                new MovieWriter() { Id = 5, MovieId = "tt0133093", WriterId = "nm0905152" },
                new MovieWriter() { Id = 6, MovieId = "tt0133093", WriterId = "nm0905154" },
                new MovieWriter() { Id = 7, MovieId = "tt0234215", WriterId = "nm0905152" },
                new MovieWriter() { Id = 8, MovieId = "tt0234215", WriterId = "nm0905154" },
                new MovieWriter() { Id = 9, MovieId = "tt0499549", WriterId = "nm0000116" },
                new MovieWriter() { Id = 10, MovieId = "tt1517238", WriterId = "nm0807023" },
                new MovieWriter() { Id = 11, MovieId = "tt1854506", WriterId = "nm0150043" },
                new MovieWriter() { Id = 12, MovieId = "tt1854506", WriterId = "nm0827500" },
                new MovieWriter() { Id = 13, MovieId = "tt2076307", WriterId = "nm0956913" },
                new MovieWriter() { Id = 14, MovieId = "tt6933454", WriterId = "nm0610219" },
                new MovieWriter() { Id = 15, MovieId = "tt6933454", WriterId = "nm0807023" },
                new MovieWriter() { Id = 16, MovieId = "tt7220696", WriterId = "nm0474289" },
                new MovieWriter() { Id = 17, MovieId = "tt7220696", WriterId = "nm0718558" },
                new MovieWriter() { Id = 18, MovieId = "tt8923874", WriterId = "nm10086396" }

                );

        }
        public static void SeedCategories(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Action"
                }, new Category
                {
                    Id = 2,
                    Name = "Sci-Fi"
                }, new Category
                {
                    Id = 3,
                    Name = "Adventure"
                }, new Category
                {
                    Id = 4,
                    Name = "Fantasy"
                }, new Category
                {
                    Id = 5,
                    Name = "Horror"
                }, new Category
                {
                    Id = 6,
                    Name = "Drama"
                }, new Category
                {
                    Id = 7,
                    Name = "Family"
                }, new Category
                {
                    Id = 8,
                    Name = "Mystery"
                }, new Category
                {
                    Id = 9,
                    Name = "Documentary"
                }, new Category
                {
                    Id = 10,
                    Name = "Comedy"
                }, new Category
                {
                    Id = 11,
                    Name = "Crime"
                }, new Category
                {
                    Id = 12,
                    Name = "Thriller"
                }, new Category
                {
                    Id = 13,
                    Name = "Romance"
                }, new Category
                {
                    Id = 14,
                    Name = "History"
                }, new Category
                {
                    Id = 15,
                    Name = "War"
                }
            );
        }

    }
}
