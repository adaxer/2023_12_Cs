using System.Net.Mime;

namespace MiniApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.


        var app = builder.Build();

        // Configure the HTTP request pipeline.

        app.MapGet("/hello", () =>
        {
            return "hello!";
        });

        app.MapGet("/image", () =>
        {
            return Results.File(Path.Combine(Environment.CurrentDirectory, "assets", "car.png"), contentType: "image/png");
        });

        app.Run();
    }
}
