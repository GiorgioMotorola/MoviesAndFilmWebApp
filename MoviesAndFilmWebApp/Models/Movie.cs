using MoviesAndFilmWebApp.Enums;
using System.ComponentModel.DataAnnotations;

namespace MoviesAndFilmWebApp.Models
{
    public class Movie
    {
        private MPAARatingCategory ratingCategory1;

        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Stars { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Writer { get; set; }
        [Required]
        public string Genre { get; set; }
        [Range(1.0, 10.0)]
        public double UserRating { get; set; }
        [Required]
        public string Plot { get; set; }

        public string MPAARating { get; set; }
        public string RunTime { get; set; }
        public string ReleaseYear { get; set; }
    }
}
