namespace ApiService;

public class ForecastDataService : IWeatherForecastService
{
    private readonly IDataConnection connection;

    public ForecastDataService(IDataConnection connection)
    {
        this.connection = connection;
    }

    public WeatherForecast[] GetForecasts()
    {
        // Verwende connection
        return Array.Empty<WeatherForecast>();
    }
}
