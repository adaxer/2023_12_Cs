using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieBase.Common;
using MovieBase.Data;
using System.Diagnostics;

namespace EfStudies;

internal class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddDbContext<MovieContext>(o =>
        {
            o.UseInMemoryDatabase("movies.db");
            o.EnableSensitiveDataLogging().LogTo(Console.WriteLine);
        });
        var provider = services.BuildServiceProvider();

        var db = provider.GetRequiredService<MovieContext>();

        var firstTen = db.Movies.Take(10).ToList();

        firstTen.ForEach(Dump);

        Console.WriteLine("\n");
      
        Dump(db.Find<Movie>(47)!);

        Console.WriteLine();

        var groups = from m in db.Movies.ToList()
                     group m by m.Director into newGroup
                     orderby newGroup.Key
                     select newGroup;

        foreach (var group in groups)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(group.Key);
            Console.ResetColor();

            foreach (var movie in group)
            {
                Dump(movie);
            }
        }

        // select director, count(*) from movies group by director
        var groups2 = from m in db.Movies.ToList()
                     group m by m.Director into newGroup
                     select new { count = newGroup.Count(), director = newGroup.Key }; // select auch Director

        foreach (var group2 in groups2)
        {
            Console.WriteLine($"{group2}");
        }

        db.Movies.Remove(db.Find<Movie>(1)!);
        Console.WriteLine(db.SaveChanges());

        Movie ten = db.Find<Movie>(10)!;
        ten.Title = "Changed";
        Console.WriteLine(db.SaveChanges());

        // Beide kommen vom Client aus der Website oder Mobilapp
        Movie newTen = new Movie { Id = 10, Title = "Ganz anders", Director = "Niemand" }; 
        Movie newMovie = new Movie { Id = 0, Title = "New One", Director = "Niemand" };
        db.Add(newMovie);
        db.SaveChanges();

        db.Entry(ten).CurrentValues.SetValues(newTen);
        Console.WriteLine(db.SaveChanges());

        db = provider.GetRequiredService<MovieContext>();

        Dump(db.Find<Movie>(10)!);

        db.Movies.Skip(90).ToList().ForEach(Dump);

        Console.ReadLine();
    }

    private static void Dump(Movie movie) => Console.WriteLine($"{movie.Id}: {movie.Title}, {movie.Director}, {movie.Released}");
}
