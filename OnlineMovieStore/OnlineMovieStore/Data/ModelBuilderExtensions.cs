﻿using Microsoft.EntityFrameworkCore;
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
                new Movie() { UsdPrice = 14.99M, Id = "tt0133093", RatingId = 1, RuntimeMinutes = 136, StartYear = 1999, Title = "The Matrix", Type = Enums.MovieType.movie, Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers." },
                new Movie() { UsdPrice = 15.99M, Id = "tt0234215", RatingId = 2, RuntimeMinutes = 138, StartYear = 2003, Title = "The Matrix Reloaded", Type = Enums.MovieType.movie, Description = "Following the events of Matrix (1999), Neo and the rebel leaders estimate they have 72 hours until 250,000 probes discover Zion and destroy it and its inhabitants. Neo must decide how he can save Trinity from a dark fate in his dreams." },
                new Movie() { UsdPrice = 16.99M, Id = "tt0499549", RatingId = 3, RuntimeMinutes = 162, StartYear = 2009, Title = "Avatar", Type = Enums.MovieType.movie, Description = "A paraplegic marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home." },
                new Movie() { UsdPrice = 17.99M, Id = "tt1775309", RatingId = 4, RuntimeMinutes = 93, StartYear = 2011, Title = "Avatar", Type = Enums.MovieType.movie, Description = "A student in high school obtains a rare avatar on a social networking site and the boundary between her real and online identities becomes blurred." },
                new Movie() { UsdPrice = 13.99M, Id = "tt1854506", RatingId = 5, RuntimeMinutes = 80, StartYear = 2011, Title = "Aliens vs. Avatars", Type = Enums.MovieType.movie, Description = "Six college friends find themselves caught up in a cat and mouse hunt with a race of creatures who possess the ability to transform into anything from which it has consumed DNA." },
                new Movie() { UsdPrice = 12.99M, Id = "tt8968844", RatingId = 6, RuntimeMinutes = 80, StartYear = 2018, Title = "Samhain: A Halloween Horror Movie", Type = Enums.MovieType.movie, Description = "Camille is heading to the west coast to start new life. Camille has one last night in town and she is house sitting for some extra cash. Question is will this be her last night in Telford, or her last night on this earth?" },
                new Movie() { UsdPrice = 11.99M, Id = "tt9024440", RatingId = 7, RuntimeMinutes = 50, StartYear = 2018, Title = "A Meowy Halloween", Type = Enums.MovieType.movie, Description = "When their home is haunted by a dream spirit, it's up to Whiskers to figure out what is haunting them and how to send the ghost to the other side. She'll use ghost hunting, the Nekkomeownicon, and Wally's credit card to get the job done." },
                new Movie() { UsdPrice = 14.99M, Id = "tt0054395", RatingId = 8, RuntimeMinutes = 104, StartYear = 1961, Title = "Dead Eyes of London", Type = Enums.MovieType.movie, Description = "Wealthy, heavily insured men are being murdered at an alarming rate. Scotland Yard investigates and finds clues that lead to a ring of blind men, led by a mysterious \"reverend.\"" },
                new Movie() { UsdPrice = 15.99M, Id = "tt7578416", RatingId = 9, RuntimeMinutes = 106, StartYear = 2017, Title = "We, the Dead", Type = Enums.MovieType.movie, Description = "Hui Ling's life will truly begin as soon as she makes it to Taiwan. Or so she thinks. Right now, she is at the Thai-Malaysian border, working odd jobs and saving money. Determined to make it even when she loses all her savings, she accepts her boss' offer for quick money as a human trafficker. As she descends into the darkness of her sordid trade, she witnesses the atrocities perpetrated against the Rohingya immigrants. Her beacon of light through this is Wei, a young hospital worker who believes that she is a woman from his past. AQÉRAT is a sweeping tale of displacement and morality in contemporary Malaysia." },
                new Movie() { UsdPrice = 16.99M, Id = "tt7640234", RatingId = 10, RuntimeMinutes = 65, StartYear = 2018, Title = "Drown Among the Dead", Type = Enums.MovieType.movie, Description = "An old comedian lies buried up to his neck in the middle of a desert. A strange woman bearing a nail-bat finds him and intends to kill him. To save himself, the prisoner lures her with mysterious words, distracting her with stories of a mythical threshold that holds the absolute truth. She is trapped by the words as she struggles with her own existential conflicts in a world where the boundaries between truth, lies, reality, and imagination are blurry. This bizarre situation detonates a monologue about solitude, emptiness, love, absurdity, fear of death, and the fragility of human passions." },
                new Movie() { UsdPrice = 17.99M, Id = "tt0091805", RatingId = 11, RuntimeMinutes = 93, StartYear = 1986, Title = "Puzzle", Type = Enums.MovieType.movie, Description = "A bank robbery goes wrong. The robbers, two of them unemployed family men, take two hostages, one of them needing heart medication, and leave them in an apartment, tied to a bomb. The police has to find the apartment before the bomb explodes. At the same time, in the same house, two old men are solving a jigsaw puzzle, and a female cellist practices the Bach cello suites." },
                new Movie() { UsdPrice = 13.99M, Id = "tt0870915", RatingId = 12, RuntimeMinutes = 91, StartYear = 2006, Title = "Puzzle", Type = Enums.MovieType.movie, Description = "Five strangers, each with his own special talents, are recruited by the mysterious 'X'. They do not know why they are brought together, but nonetheless agree to a series of potentially lucrative schemes. A planned bank robbery goes awry when a minor mistake leads to a hostage situation. The robbery is orchestrated by Hwan. When Hwan turns up dead at the designated meeting spot, the remaining men realize something is seriously wrong, and suspicion flares." },
                new Movie() { UsdPrice = 12.99M, Id = "tt1517238", RatingId = 13, RuntimeMinutes = 87, StartYear = 2009, Title = "Puzzle", Type = Enums.MovieType.movie, Description = "Maria's husband and children give her a puzzle for her 50th birthday. She's delighted, and finds it a great discovery. Not only does the patient housewife have fun doing the puzzles, she's also really good at them. Overflowing with enthusiasm for her new-found passion, she goes back to the shop where they bought the gift for another puzzle. There her eye is caught by a notice on the message board: \"Partner for puzzle tournament wanted\". Maria musters her courage and, despite her family's misgivings, answers the announcement." },
                new Movie() { UsdPrice = 11.99M, Id = "tt2076307", RatingId = 14, RuntimeMinutes = 90, StartYear = 2013, Title = "Puzzle", Type = Enums.MovieType.movie, Description = "A middle-aged man fed up with his marriage embarks on a torrid affair with a sultry young artist, while a blind, old writer defies the odds and reconnects with the enduring love of his life\n\nA repressed middle aged man realizes that his life had become one of misery and loneliness. After becoming friends with a blind writer he had to evict from his house, he finds the inspiration and courage he needs to break all the rules he had been forced to abide by and to reconnect with life's joy and excitement." },
                new Movie() { UsdPrice = 18.99M, Id = "tt3492330", RatingId = 15, RuntimeMinutes = 85, StartYear = 2014, Title = "Puzzle", Type = Enums.MovieType.movie, Description = "High school student Azusa jumps off from the rooftop of a school building, but she survives. One month later, the school is taken over by group of people wearing bizarre masks. A pregnant teacher is imprisoned, while the head director of the school and male students disappear. Azusa then finds pieces of a puzzle in an envelope given to her by classmate Shigeo. The puzzle pieces holds the key to solve the case. Azusa chases after Shigeo and she sees something which is unimaginable." },
                new Movie() { UsdPrice = 19.99M, Id = "tt6933454", RatingId = 16, RuntimeMinutes = 103, StartYear = 2018, Title = "Puzzle", Type = Enums.MovieType.movie, Description = "Agnes, taken for granted as a suburban mother, discovers a passion for solving jigsaw puzzles which unexpectedly draws her into a new world - where her life unfolds in ways she could never have imagined." },
                new Movie() { UsdPrice = 20.99M, Id = "tt7220696", RatingId = 17, RuntimeMinutes = 103, StartYear = 2018, Title = "Laugh or Die", Type = Enums.MovieType.movie, Description = "In a detention camp in 1918, a group of Finnish actors are sentenced to death. When an important German general arrives, the camp's vicious commandant forges out a cruel plan: the imprisoners have to perform a comedy - and if they can make the visiting general laugh, they will be spared. A story about zest for life and power of laughter. Based on true events." }
               
                );
        }
        public static void SeedMovieCategories(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieCategory>().HasData(
                new MovieCategory() { MovieId = "tt0133093", CategoryId = 1 },
                new MovieCategory() { MovieId = "tt0234215", CategoryId = 1 },
                new MovieCategory() { MovieId = "tt0499549", CategoryId = 1 },
                new MovieCategory() { MovieId = "tt0499549", CategoryId = 3 },
                new MovieCategory() { MovieId = "tt0499549", CategoryId = 4 },
                new MovieCategory() { MovieId = "tt1775309", CategoryId = 5 },
                new MovieCategory() { MovieId = "tt1854506", CategoryId = 5 },
                new MovieCategory() { MovieId = "tt8968844", CategoryId = 5 },
                new MovieCategory() { MovieId = "tt9024440", CategoryId = 10 },
                new MovieCategory() { MovieId = "tt9024440", CategoryId = 7 },
                new MovieCategory() { MovieId = "tt9024440", CategoryId = 5 },
                new MovieCategory() { MovieId = "tt0054395", CategoryId = 11 },
                new MovieCategory() { MovieId = "tt0054395", CategoryId = 5 },
                new MovieCategory() { MovieId = "tt0054395", CategoryId = 8 },
                new MovieCategory() { MovieId = "tt7578416", CategoryId = 11 },
                new MovieCategory() { MovieId = "tt7640234", CategoryId = 3 },
                new MovieCategory() { MovieId = "tt7640234", CategoryId = 6 },
                new MovieCategory() { MovieId = "tt7640234", CategoryId = 5 },
                new MovieCategory() { MovieId = "tt0091805", CategoryId = 1 },
                new MovieCategory() { MovieId = "tt0091805", CategoryId = 11 },
                new MovieCategory() { MovieId = "tt0091805", CategoryId = 12 },
                new MovieCategory() { MovieId = "tt0870915", CategoryId = 11 },
                new MovieCategory() { MovieId = "tt0870915", CategoryId = 12 },
                new MovieCategory() { MovieId = "tt1517238", CategoryId = 6 },
                new MovieCategory() { MovieId = "tt2076307", CategoryId = 6 },
                new MovieCategory() { MovieId = "tt2076307", CategoryId = 7 },
                new MovieCategory() { MovieId = "tt2076307", CategoryId = 13 },
                new MovieCategory() { MovieId = "tt3492330", CategoryId = 5 },
                new MovieCategory() { MovieId = "tt3492330", CategoryId = 12 },
                new MovieCategory() { MovieId = "tt6933454", CategoryId = 6 },
                new MovieCategory() { MovieId = "tt7220696", CategoryId = 6 },
                new MovieCategory() { MovieId = "tt7220696", CategoryId = 14 },
                new MovieCategory() { MovieId = "tt7220696", CategoryId = 15 }
            );
        }


    }
}
