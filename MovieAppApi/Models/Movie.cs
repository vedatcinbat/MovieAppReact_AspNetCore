namespace MovieAppApi.Models {
    public class Movie {
        public int MovieId {get; set;}
        public string? MovieTitle {get; set;}
        public string? MovieGenre {get; set;}
        public int MovieYear {get; set;}
        public Double MovieImdbScore {get; set;}
        public int MovieMetaScore {get; set;}
        public string? MovieDescription {get; set;}
        public string? MovieDirector {get; set;}
        public string? MovieCasts {get; set;}

    }
}