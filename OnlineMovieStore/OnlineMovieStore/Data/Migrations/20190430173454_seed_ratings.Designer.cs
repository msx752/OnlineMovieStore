﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineMovieStore.Data;

namespace OnlineMovieStore.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190430173454_seed_ratings")]
    partial class seed_ratings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview4.19216.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("OnlineMovieStore.Data.Tables.User", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OnlineMovieStore.Data.Tables.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sci-Fi"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Family"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Documentary"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Crime"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 14,
                            Name = "History"
                        },
                        new
                        {
                            Id = 15,
                            Name = "War"
                        });
                });

            modelBuilder.Entity("OnlineMovieStore.Data.Tables.Director", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("FullName");

                    b.HasKey("Id");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            Id = "nm0901138",
                            FullName = "Alfred Vohrer"
                        },
                        new
                        {
                            Id = "nm0173775",
                            FullName = "Lluís Josep Comerón"
                        },
                        new
                        {
                            Id = "nm0905152",
                            FullName = "Lilly Wachowski"
                        },
                        new
                        {
                            Id = "nm0905154",
                            FullName = "Lana Wachowski"
                        },
                        new
                        {
                            Id = "nm0000116",
                            FullName = "James Cameron"
                        },
                        new
                        {
                            Id = "nm0807023",
                            FullName = "Natalia Smirnoff"
                        },
                        new
                        {
                            Id = "nm0006955",
                            FullName = "Lewis Schoenbrun"
                        },
                        new
                        {
                            Id = "nm0956913",
                            FullName = "Andrei Zinca"
                        },
                        new
                        {
                            Id = "nm0474289",
                            FullName = "Heikki Kujanpää"
                        },
                        new
                        {
                            Id = "nm10086396",
                            FullName = "Bradley Alcime"
                        },
                        new
                        {
                            Id = "nm10114969",
                            FullName = "Ahmed Mansour"
                        });
                });

            modelBuilder.Entity("OnlineMovieStore.Data.Tables.Movie", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Description");

                    b.Property<int>("RatingId");

                    b.Property<int>("RuntimeMinutes");

                    b.Property<int>("StartYear");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("RatingId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("OnlineMovieStore.Data.Tables.MovieCategory", b =>
                {
                    b.Property<string>("MovieId");

                    b.Property<int>("CategoryId");

                    b.HasKey("MovieId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("MovieCategories");
                });

            modelBuilder.Entity("OnlineMovieStore.Data.Tables.MovieDirector", b =>
                {
                    b.Property<string>("MovieId");

                    b.Property<string>("DirectorId");

                    b.HasKey("MovieId", "DirectorId");

                    b.HasIndex("DirectorId");

                    b.ToTable("MovieDirectors");
                });

            modelBuilder.Entity("OnlineMovieStore.Data.Tables.MovieWriter", b =>
                {
                    b.Property<string>("MovieId");

                    b.Property<string>("WriterId");

                    b.HasKey("MovieId", "WriterId");

                    b.HasIndex("WriterId");

                    b.ToTable("MovieWriters");
                });

            modelBuilder.Entity("OnlineMovieStore.Data.Tables.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AverageRating");

                    b.Property<string>("MovieId");

                    b.Property<int>("NumVotes");

                    b.HasKey("Id");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AverageRating = 87.0,
                            MovieId = "tt0133093",
                            NumVotes = 1493180
                        },
                        new
                        {
                            Id = 2,
                            AverageRating = 72.0,
                            MovieId = "tt0234215",
                            NumVotes = 475351
                        },
                        new
                        {
                            Id = 3,
                            AverageRating = 78.0,
                            MovieId = "tt0499549",
                            NumVotes = 1036901
                        },
                        new
                        {
                            Id = 4,
                            AverageRating = 62.0,
                            MovieId = "tt1775309",
                            NumVotes = 41
                        },
                        new
                        {
                            Id = 5,
                            AverageRating = 16.0,
                            MovieId = "tt1854506",
                            NumVotes = 1538
                        },
                        new
                        {
                            Id = 6,
                            AverageRating = 25.0,
                            MovieId = "tt8968844",
                            NumVotes = 17
                        },
                        new
                        {
                            Id = 7,
                            AverageRating = 67.0,
                            MovieId = "tt9024440",
                            NumVotes = 15
                        },
                        new
                        {
                            Id = 8,
                            AverageRating = 64.0,
                            MovieId = "tt0054395",
                            NumVotes = 828
                        },
                        new
                        {
                            Id = 9,
                            AverageRating = 67.0,
                            MovieId = "tt7578416",
                            NumVotes = 23
                        },
                        new
                        {
                            Id = 10,
                            AverageRating = 54.0,
                            MovieId = "tt7640234",
                            NumVotes = 29
                        },
                        new
                        {
                            Id = 11,
                            AverageRating = 61.0,
                            MovieId = "tt0091805",
                            NumVotes = 41
                        },
                        new
                        {
                            Id = 12,
                            AverageRating = 64.0,
                            MovieId = "tt0870915",
                            NumVotes = 260
                        },
                        new
                        {
                            Id = 13,
                            AverageRating = 67.0,
                            MovieId = "tt1517238",
                            NumVotes = 517
                        },
                        new
                        {
                            Id = 14,
                            AverageRating = 68.0,
                            MovieId = "tt2076307",
                            NumVotes = 66
                        },
                        new
                        {
                            Id = 15,
                            AverageRating = 58.0,
                            MovieId = "tt3492330",
                            NumVotes = 218
                        },
                        new
                        {
                            Id = 16,
                            AverageRating = 67.0,
                            MovieId = "tt6933454",
                            NumVotes = 3404
                        },
                        new
                        {
                            Id = 17,
                            AverageRating = 67.0,
                            MovieId = "tt7220696",
                            NumVotes = 391
                        });
                });

            modelBuilder.Entity("OnlineMovieStore.Data.Tables.Writer", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("FullName");

                    b.HasKey("Id");

                    b.ToTable("Writers");

                    b.HasData(
                        new
                        {
                            Id = "nm0908624",
                            FullName = "Edgar Wallace"
                        },
                        new
                        {
                            Id = "nm0251912",
                            FullName = "Egon Eis"
                        },
                        new
                        {
                            Id = "nm0525742",
                            FullName = "Wolfgang Lukschy"
                        },
                        new
                        {
                            Id = "nm0173775",
                            FullName = "Lluís Josep Comerón"
                        },
                        new
                        {
                            Id = "nm0905152",
                            FullName = "Lilly Wachowski"
                        },
                        new
                        {
                            Id = "nm0905154",
                            FullName = "Lana Wachowski"
                        },
                        new
                        {
                            Id = "nm0000116",
                            FullName = "James Cameron"
                        },
                        new
                        {
                            Id = "nm0807023",
                            FullName = "Natalia Smirnoff"
                        },
                        new
                        {
                            Id = "nm0150043",
                            FullName = "Ted Chalmers"
                        },
                        new
                        {
                            Id = "nm0827500",
                            FullName = "David S. Sterling"
                        },
                        new
                        {
                            Id = "nm0956913",
                            FullName = "Andrei Zinca"
                        },
                        new
                        {
                            Id = "nm0610219",
                            FullName = "Oren Moverman"
                        },
                        new
                        {
                            Id = "nm0474289",
                            FullName = "Heikki Kujanpää"
                        },
                        new
                        {
                            Id = "nm0718558",
                            FullName = "Mikko Reitala"
                        },
                        new
                        {
                            Id = "nm10086396",
                            FullName = "Bradley Alcime"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OnlineMovieStore.Data.Tables.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OnlineMovieStore.Data.Tables.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineMovieStore.Data.Tables.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OnlineMovieStore.Data.Tables.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineMovieStore.Data.Tables.Movie", b =>
                {
                    b.HasOne("OnlineMovieStore.Data.Tables.Rating", "Rating")
                        .WithMany("Movies")
                        .HasForeignKey("RatingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineMovieStore.Data.Tables.MovieCategory", b =>
                {
                    b.HasOne("OnlineMovieStore.Data.Tables.Category", "Category")
                        .WithMany("Categories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineMovieStore.Data.Tables.Movie", "Movie")
                        .WithMany("Categories")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineMovieStore.Data.Tables.MovieDirector", b =>
                {
                    b.HasOne("OnlineMovieStore.Data.Tables.Director", "Director")
                        .WithMany("MovieDirectors")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineMovieStore.Data.Tables.Movie", "Movie")
                        .WithMany("MovieDirectors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineMovieStore.Data.Tables.MovieWriter", b =>
                {
                    b.HasOne("OnlineMovieStore.Data.Tables.Movie", "Movie")
                        .WithMany("MovieWriters")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineMovieStore.Data.Tables.Writer", "Writer")
                        .WithMany("MovieWriters")
                        .HasForeignKey("WriterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
