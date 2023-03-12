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

        //public MPAARatingCategory MPAA { get; set; }
        public string MPAARating { get; set; }
        //do props for hours and minutes
        public string RunTime { get; set; }
        //make int and add a range of whenever movies started and like 2023
        public string ReleaseYear { get; set; }
    }
}
