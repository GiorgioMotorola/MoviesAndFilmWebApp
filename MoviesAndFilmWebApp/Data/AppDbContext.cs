using Microsoft.EntityFrameworkCore;
using MoviesAndFilmWebApp.Models;

namespace MoviesAndFilmWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
