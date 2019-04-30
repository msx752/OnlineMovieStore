using Microsoft.EntityFrameworkCore;
using OnlineMovieStore.Data.Tables;

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
                new MovieDirector() { MovieId = "tt0054395", DirectorId = "nm0901138" },
                new MovieDirector() { MovieId = "tt0133093", DirectorId = "nm0905152" },
                new MovieDirector() { MovieId = "tt0133093", DirectorId = "nm0905154" },
                new MovieDirector() { MovieId = "tt0234215", DirectorId = "nm0905154" },
                new MovieDirector() { MovieId = "tt0234215", DirectorId = "nm0905152" },
                new MovieDirector() { MovieId = "tt0499549", DirectorId = "nm0000116" },
                new MovieDirector() { MovieId = "tt1517238", DirectorId = "nm0807023" },
                new MovieDirector() { MovieId = "tt1854506", DirectorId = "nm0006955" },
                new MovieDirector() { MovieId = "tt2076307", DirectorId = "nm0956913" },
                new MovieDirector() { MovieId = "tt7220696", DirectorId = "nm0474289" }
               // new MovieDirector() { MovieId = "tt8923874", DirectorId = "nm10086396" },
               // new MovieDirector() { MovieId = "tt8984748", DirectorId = "nm10114969" }

                );

        }
        public static void SeedMovieWriters(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieWriter>().HasData(
                new MovieWriter() { MovieId = "tt0054395", WriterId = "nm0908624" },
                new MovieWriter() { MovieId = "tt0054395", WriterId = "nm0251912" },
                new MovieWriter() { MovieId = "tt0054395", WriterId = "nm0525742" },
                new MovieWriter() { MovieId = "tt0091805", WriterId = "nm0173775" },
                new MovieWriter() { MovieId = "tt0133093", WriterId = "nm0905152" },
                new MovieWriter() { MovieId = "tt0133093", WriterId = "nm0905154" },
                new MovieWriter() { MovieId = "tt0234215", WriterId = "nm0905152" },
                new MovieWriter() { MovieId = "tt0234215", WriterId = "nm0905154" },
                new MovieWriter() { MovieId = "tt0499549", WriterId = "nm0000116" },
                new MovieWriter() { MovieId = "tt1517238", WriterId = "nm0807023" },
                new MovieWriter() { MovieId = "tt1854506", WriterId = "nm0150043" },
                new MovieWriter() { MovieId = "tt1854506", WriterId = "nm0827500" },
                new MovieWriter() { MovieId = "tt2076307", WriterId = "nm0956913" },
                new MovieWriter() { MovieId = "tt6933454", WriterId = "nm0610219" },
                new MovieWriter() { MovieId = "tt6933454", WriterId = "nm0807023" },
                new MovieWriter() { MovieId = "tt7220696", WriterId = "nm0474289" },
                new MovieWriter() { MovieId = "tt7220696", WriterId = "nm0718558" }
               // new MovieWriter() { MovieId = "tt8923874", WriterId = "nm10086396" }

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
        public static void SeedRatings(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rating>().HasData(
            new Rating() { Id = 1, AverageRating = 87, NumVotes = 1493180, MovieId = "tt0133093" },
            new Rating() { Id = 2, AverageRating = 72, NumVotes = 475351, MovieId = "tt0234215" },
            new Rating() { Id = 3, AverageRating = 78, NumVotes = 1036901, MovieId = "tt0499549" },
            new Rating() { Id = 4, AverageRating = 62, NumVotes = 41, MovieId = "tt1775309" },
            new Rating() { Id = 5, AverageRating = 16, NumVotes = 1538, MovieId = "tt1854506" },
            new Rating() { Id = 6, AverageRating = 25, NumVotes = 17, MovieId = "tt8968844" },
            new Rating() { Id = 7, AverageRating = 67, NumVotes = 15, MovieId = "tt9024440" },
            new Rating() { Id = 8, AverageRating = 64, NumVotes = 828, MovieId = "tt0054395" },
            new Rating() { Id = 9, AverageRating = 67, NumVotes = 23, MovieId = "tt7578416" },
            new Rating() { Id = 10, AverageRating = 54, NumVotes = 29, MovieId = "tt7640234" },
            new Rating() { Id = 11, AverageRating = 61, NumVotes = 41, MovieId = "tt0091805" },
            new Rating() { Id = 12, AverageRating = 64, NumVotes = 260, MovieId = "tt0870915" },
            new Rating() { Id = 13, AverageRating = 67, NumVotes = 517, MovieId = "tt1517238" },
            new Rating() { Id = 14, AverageRating = 68, NumVotes = 66, MovieId = "tt2076307" },
            new Rating() { Id = 15, AverageRating = 58, NumVotes = 218, MovieId = "tt3492330" },
            new Rating() { Id = 16, AverageRating = 67, NumVotes = 3404, MovieId = "tt6933454" },
            new Rating() { Id = 17, AverageRating = 67, NumVotes = 391, MovieId = "tt7220696" }

            );
        }
        public static void SeedMovies(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = "tt0133093", RatingId = 1, RuntimeMinutes = 136, StartYear = 1999, Title = "The Matrix", Type = Enums.MovieType.movie, Description = "" },
                new Movie() { Id = "tt0234215", RatingId = 2, RuntimeMinutes = 138, StartYear = 2003, Title = "The Matrix Reloaded", Type = Enums.MovieType.movie, Description = "" },
                new Movie() { Id = "tt0499549", RatingId = 3, RuntimeMinutes = 162, StartYear = 2009, Title = "Avatar", Type = Enums.MovieType.movie, Description = "" },
                new Movie() { Id = "tt1775309", RatingId = 4, RuntimeMinutes = 93, StartYear = 2011, Title = "Avatar", Type = Enums.MovieType.movie, Description = "" },
                new Movie() { Id = "tt1854506", RatingId = 5, RuntimeMinutes = 80, StartYear = 2011, Title = "Aliens vs. Avatars", Type = Enums.MovieType.movie, Description = "" },
                new Movie() { Id = "tt8968844", RatingId = 6, RuntimeMinutes = 80, StartYear = 2018, Title = "Samhain: A Halloween Horror Movie", Type = Enums.MovieType.movie, Description = "" },
                new Movie() { Id = "tt9024440", RatingId = 7, RuntimeMinutes = 50, StartYear = 2018, Title = "A Meowy Halloween", Type = Enums.MovieType.movie, Description = "" },
                new Movie() { Id = "tt0054395", RatingId = 8, RuntimeMinutes = 104, StartYear = 1961, Title = "Dead Eyes of London", Type = Enums.MovieType.movie, Description = "" },
                new Movie() { Id = "tt7578416", RatingId = 9, RuntimeMinutes = 106, StartYear = 2017, Title = "We, the Dead", Type = Enums.MovieType.movie, Description = "" },
                new Movie() { Id = "tt7640234", RatingId = 10, RuntimeMinutes = 65, StartYear = 2018, Title = "Drown Among the Dead", Type = Enums.MovieType.movie, Description = "" },
                new Movie() { Id = "tt0091805", RatingId = 11, RuntimeMinutes = 93, StartYear = 1986, Title = "Puzzle", Type = Enums.MovieType.movie, Description = "" },
                new Movie() { Id = "tt0870915", RatingId = 12, RuntimeMinutes = 91, StartYear = 2006, Title = "Puzzle", Type = Enums.MovieType.movie, Description = "" },
                new Movie() { Id = "tt1517238", RatingId = 13, RuntimeMinutes = 87, StartYear = 2009, Title = "Puzzle", Type = Enums.MovieType.movie, Description = "" },
                new Movie() { Id = "tt2076307", RatingId = 14, RuntimeMinutes = 90, StartYear = 2013, Title = "Puzzle", Type = Enums.MovieType.movie, Description = "" },
                new Movie() { Id = "tt3492330", RatingId = 15, RuntimeMinutes = 85, StartYear = 2014, Title = "Puzzle", Type = Enums.MovieType.movie, Description = "" },
                new Movie() { Id = "tt6933454", RatingId = 16, RuntimeMinutes = 103, StartYear = 2018, Title = "Puzzle", Type = Enums.MovieType.movie, Description = "" },
                new Movie() { Id = "tt7220696", RatingId = 17, RuntimeMinutes = 103, StartYear = 2018, Title = "Laugh or Die", Type = Enums.MovieType.movie, Description = "" }
                );
        }



    }
}
