using Microsoft.EntityFrameworkCore;
using MovieAppApi.Models;


namespace MovieAppApi.Data {
    public class MoviesRepositoryContext : DbContext {

        public MoviesRepositoryContext(DbContextOptions<MoviesRepositoryContext> options) : base(options) {}


        public DbSet<Movie> Movies {get; set;}



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>()
            .HasData(
                new Movie {MovieId = 1, MovieTitle = "The Shawshank Redemption", MovieGenre = "Drama", MovieYear = 1994, MovieImdbScore = 9.3, MovieMetaScore = 82,MovieDescription = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.", MovieDirector = "Frank Darabont", MovieCasts = "Tim Robbins, Morgan Freeman, William Sadler"},
                new Movie {MovieId = 2, MovieTitle = "The Godfather", MovieGenre = "Crime, Drama", MovieYear = 1972, MovieImdbScore = 9.2, MovieMetaScore = 100,MovieDescription = "Don Vito Corleone, head of a mafia family, decides to hand over his empire to his youngest son Michael. However, his decision unintentionally puts the lives of his loved ones in grave danger.", MovieDirector = "Francis Ford Coppola", MovieCasts = "Marlon Brando, Al Pacino, James Caan, Diane Keaton"},
                new Movie {MovieId = 3, MovieTitle = "The Dark Knight", MovieGenre = "Action, Crime, Drama", MovieYear = 2008, MovieImdbScore = 9.0, MovieMetaScore = 84,MovieDescription = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", MovieDirector = " Christopher Nolan", MovieCasts ="Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine"},
                new Movie {MovieId = 4, MovieTitle = "Schindler's List", MovieGenre = "Biography, Drama, History", MovieYear = 1993, MovieImdbScore = 9.0, MovieMetaScore = 95,MovieDescription = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", MovieDirector = "Steven Spielberg", MovieCasts ="Liam Neeson, Ralph Fiennes, Ben Kingsley, Caroline Goodall"},
                new Movie {MovieId = 5, MovieTitle = "12 Angry Men", MovieGenre = "Crime, Drama", MovieYear = 1957, MovieImdbScore = 9.0, MovieMetaScore = 97,MovieDescription = "The jury in a New York City murder trial is frustrated by a single member whose skeptical caution forces them to more carefully consider the evidence before jumping to a hasty verdict.", MovieDirector = "Sidney Lumet", MovieCasts ="Henry Fonda, Lee J. Cobb, Martin Balsam, John Fiedler"},
                new Movie {MovieId = 6, MovieTitle = "The Godfather Part II", MovieGenre = "Crime, Drama", MovieYear = 1974, MovieImdbScore = 9.0, MovieMetaScore = 81,MovieDescription = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", MovieDirector = "Francis Ford Coppola ", MovieCasts ="Al Pacino, Robert De Niro, Robert Duvall, Diane Keaton"},
                new Movie {MovieId = 7, MovieTitle = "The Lord of the Rings: The Return of the King ", MovieGenre = "Action, Adventure, Drama", MovieYear = 2003, MovieImdbScore = 9.0, MovieMetaScore = 98,MovieDescription = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", MovieDirector = "Peter Jackson", MovieCasts ="Elijah Wood, Viggo Mortensen, Ian McKellen, Orlando Bloom"}
                
            );
        }






    }
}