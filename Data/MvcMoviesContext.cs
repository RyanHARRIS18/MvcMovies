using Microsoft.EntityFrameworkCore;
using MvcMovies.Models;

namespace MvcMovies.Data
{
    public class MvcMoviesContext : DbContext
    {
        public MvcMoviesContext(DbContextOptions<MvcMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}