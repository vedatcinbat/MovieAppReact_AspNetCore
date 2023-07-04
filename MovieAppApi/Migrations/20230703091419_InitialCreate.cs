using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieAppApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieGenre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieYear = table.Column<int>(type: "int", nullable: false),
                    MovieImdbScore = table.Column<double>(type: "float", nullable: false),
                    MovieMetaScore = table.Column<int>(type: "int", nullable: false),
                    MovieDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieDirector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieCasts = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "MovieCasts", "MovieDescription", "MovieDirector", "MovieGenre", "MovieImdbScore", "MovieMetaScore", "MovieTitle", "MovieYear" },
                values: new object[,]
                {
                    { 1, "Tim Robbins, Morgan Freeman, William Sadler", "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.", "Frank Darabont", "Drama", 9.3000000000000007, 82, "The Shawshank Redemption", 1994 },
                    { 2, "Marlon Brando, Al Pacino, James Caan, Diane Keaton", "Don Vito Corleone, head of a mafia family, decides to hand over his empire to his youngest son Michael. However, his decision unintentionally puts the lives of his loved ones in grave danger.", "Francis Ford Coppola", "Crime, Drama", 9.1999999999999993, 100, "The Godfather", 1972 },
                    { 3, "Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", " Christopher Nolan", "Action, Crime, Drama", 9.0, 84, "The Dark Knight", 2008 },
                    { 4, "Liam Neeson, Ralph Fiennes, Ben Kingsley, Caroline Goodall", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", "Steven Spielberg", "Biography, Drama, History", 9.0, 95, "Schindler's List", 1993 },
                    { 5, "Henry Fonda, Lee J. Cobb, Martin Balsam, John Fiedler", "The jury in a New York City murder trial is frustrated by a single member whose skeptical caution forces them to more carefully consider the evidence before jumping to a hasty verdict.", "Sidney Lumet", "Crime, Drama", 9.0, 97, "12 Angry Men", 1957 },
                    { 6, "Al Pacino, Robert De Niro, Robert Duvall, Diane Keaton", "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", "Francis Ford Coppola ", "Crime, Drama", 9.0, 81, "The Godfather Part II", 1974 },
                    { 7, "Elijah Wood, Viggo Mortensen, Ian McKellen, Orlando Bloom", "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", "Peter Jackson", "Action, Adventure, Drama", 9.0, 98, "The Lord of the Rings: The Return of the King ", 2003 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
