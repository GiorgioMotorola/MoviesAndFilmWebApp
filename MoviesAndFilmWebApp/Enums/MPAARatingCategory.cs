using System.ComponentModel.DataAnnotations;

namespace MoviesAndFilmWebApp.Enums
{
    enum MPAARatingCategory
    {
        [Display(Name = "G")]
        G,
        [Display(Name = "PG")]
        PG,
        [Display(Name = "PG-13")]
        PG13,
        [Display(Name = "R")]
        R,
        [Display(Name = "N/A")]
        NA
    }
}
