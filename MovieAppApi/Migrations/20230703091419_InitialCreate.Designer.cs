﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieAppApi.Data;

#nullable disable

namespace MovieAppApi.Migrations
{
    [DbContext(typeof(MoviesRepositoryContext))]
    [Migration("20230703091419_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MovieAppApi.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<string>("MovieCasts")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieDirector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieGenre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MovieImdbScore")
                        .HasColumnType("float");

                    b.Property<int>("MovieMetaScore")
                        .HasColumnType("int");

                    b.Property<string>("MovieTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieYear")
                        .HasColumnType("int");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            MovieCasts = "Tim Robbins, Morgan Freeman, William Sadler",
                            MovieDescription = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.",
                            MovieDirector = "Frank Darabont",
                            MovieGenre = "Drama",
                            MovieImdbScore = 9.3000000000000007,
                            MovieMetaScore = 82,
                            MovieTitle = "The Shawshank Redemption",
                            MovieYear = 1994
                        },
                        new
                        {
                            MovieId = 2,
                            MovieCasts = "Marlon Brando, Al Pacino, James Caan, Diane Keaton",
                            MovieDescription = "Don Vito Corleone, head of a mafia family, decides to hand over his empire to his youngest son Michael. However, his decision unintentionally puts the lives of his loved ones in grave danger.",
                            MovieDirector = "Francis Ford Coppola",
                            MovieGenre = "Crime, Drama",
                            MovieImdbScore = 9.1999999999999993,
                            MovieMetaScore = 100,
                            MovieTitle = "The Godfather",
                            MovieYear = 1972
                        },
                        new
                        {
                            MovieId = 3,
                            MovieCasts = "Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine",
                            MovieDescription = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                            MovieDirector = " Christopher Nolan",
                            MovieGenre = "Action, Crime, Drama",
                            MovieImdbScore = 9.0,
                            MovieMetaScore = 84,
                            MovieTitle = "The Dark Knight",
                            MovieYear = 2008
                        },
                        new
                        {
                            MovieId = 4,
                            MovieCasts = "Liam Neeson, Ralph Fiennes, Ben Kingsley, Caroline Goodall",
                            MovieDescription = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                            MovieDirector = "Steven Spielberg",
                            MovieGenre = "Biography, Drama, History",
                            MovieImdbScore = 9.0,
                            MovieMetaScore = 95,
                            MovieTitle = "Schindler's List",
                            MovieYear = 1993
                        },
                        new
                        {
                            MovieId = 5,
                            MovieCasts = "Henry Fonda, Lee J. Cobb, Martin Balsam, John Fiedler",
                            MovieDescription = "The jury in a New York City murder trial is frustrated by a single member whose skeptical caution forces them to more carefully consider the evidence before jumping to a hasty verdict.",
                            MovieDirector = "Sidney Lumet",
                            MovieGenre = "Crime, Drama",
                            MovieImdbScore = 9.0,
                            MovieMetaScore = 97,
                            MovieTitle = "12 Angry Men",
                            MovieYear = 1957
                        },
                        new
                        {
                            MovieId = 6,
                            MovieCasts = "Al Pacino, Robert De Niro, Robert Duvall, Diane Keaton",
                            MovieDescription = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                            MovieDirector = "Francis Ford Coppola ",
                            MovieGenre = "Crime, Drama",
                            MovieImdbScore = 9.0,
                            MovieMetaScore = 81,
                            MovieTitle = "The Godfather Part II",
                            MovieYear = 1974
                        },
                        new
                        {
                            MovieId = 7,
                            MovieCasts = "Elijah Wood, Viggo Mortensen, Ian McKellen, Orlando Bloom",
                            MovieDescription = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                            MovieDirector = "Peter Jackson",
                            MovieGenre = "Action, Adventure, Drama",
                            MovieImdbScore = 9.0,
                            MovieMetaScore = 98,
                            MovieTitle = "The Lord of the Rings: The Return of the King ",
                            MovieYear = 2003
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
