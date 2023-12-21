
using Microsoft.AspNetCore.Mvc;

namespace ApiService;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Dependency Inversion: siehe
        // https://en.wikipedia.org/wiki/Dependency_inversion_principle
        builder.Services.AddKeyedScoped<IWeatherForecastService, ForecastDataService>("Data");
        builder.Services.AddKeyedScoped<IWeatherForecastService, DummyForecastService>("Dev");
        builder.Services.AddScoped<IDataConnection, StandardConnection>();

        var app = builder.Build();

        ///////////////////////////////////////////////

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapGet("/weatherforecast/dev", ([FromKeyedServices("Dev")] IWeatherForecastService service) =>
        {
            return service.GetForecasts();
        });
        app.MapGet("/weatherforecast/data", ([FromKeyedServices("Data")] IWeatherForecastService service) =>
        {
            return service.GetForecasts();
        });

        app.Run();
    }
}
