namespace ApiService;

public class DummyForecastService : IWeatherForecastService
{

    string[] summaries = new[]
    {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

    public ResultPage<WeatherForecast> GetForecasts(int pageSize, int pageNo)
    {
        var forecast = Enumerable.Range(1, 200).Skip(pageNo * pageSize).Take(pageSize).Select(index =>
                new WeatherForecast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = summaries[Random.Shared.Next(summaries.Length)]
                })
                .ToArray();

        return new ResultPage<WeatherForecast>(200, pageNo, pageSize, forecast);
    }
}
