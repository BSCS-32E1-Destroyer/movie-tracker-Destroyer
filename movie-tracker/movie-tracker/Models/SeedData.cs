using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using movie_tracker.Data;
using System;
using System.Linq;

namespace movie_tracker.Models;
public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new movie_trackerContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<movie_trackerContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "The Lord of the Rings: The Fellowship of the Rings",
                    ReleaseDate = DateTime.Parse("2001-12-20"),
                    Genre = "Fantasy/Adventure",
                    Rating = "PG",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "The Lord of the Rings: The Two Towers",
                    ReleaseDate = DateTime.Parse("2003-1-11"),
                    Genre = "Fantasy/Adventure",
                    Rating = "PG",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Blade Runner 2049",
                    ReleaseDate = DateTime.Parse("2017-8-6"),
                    Genre = "Sci-fi/Thriller",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Mad Max: Fury Road",
                    ReleaseDate = DateTime.Parse("2015-5-14"),
                    Genre = "Action/Adventure",
                    Rating = "R",
                    Price = 9.99M
                }
            );
            context.SaveChanges();
        }
    }
}