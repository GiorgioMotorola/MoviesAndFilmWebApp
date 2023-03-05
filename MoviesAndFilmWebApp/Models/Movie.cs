namespace MoviesAndFilmWebApp.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Stars { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Genre { get; set; }
        public double UserRating { get; set; }
        public string Plot { get; set; }
        public string MPAARating { get; set; }
        public string RunTime { get; set; }
        public string ReleaseYear { get; set; }
    }
}
