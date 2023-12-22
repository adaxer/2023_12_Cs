namespace FileApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        var app = builder.Build();

        // Configure the HTTP request pipeline.

        app.UseHttpsRedirection();

        app.MapGet("/hello", (HttpContext httpContext) =>
        {
            return "Hello";
        });

        app.MapGet("/image", () =>
        {
            var imagePath = Path.Combine(Environment.CurrentDirectory, "assets", "car.png");
            return Results.File(imagePath, contentType: "image/png");
        });

        app.Run();
    }
}
