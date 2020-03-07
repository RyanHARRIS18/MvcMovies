using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovies.Models;
using MvcMovies.Data;
using System;
using System.Linq;

namespace MvcMovies.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMoviesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMoviesContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "PG",
                        ImageSource = "~/images/theRM.jpg"
                    },

                    new Movie
                    {
                        Title = "Other Side of Heaven ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "G",
                        ImageSource = "~/images/theOtherSideOfHeaven.jpg"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "G",
                        ImageSource = "~/images/meetTheMormons.jpg"
                    },

                    new Movie
                    {
                        Title = "The Prince of Egypt",
                        ReleaseDate = DateTime.Parse("1998-4-15"),
                        Genre = "Animation",
                        Price = 3.99M,
                        Rating = "G",
                        ImageSource = "~/images/ThePrinceOfEgypt.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}