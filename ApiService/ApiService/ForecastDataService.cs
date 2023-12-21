namespace ApiService;

public class ForecastDataService : IWeatherForecastService
{
    private readonly IDataConnection connection;

    public ForecastDataService(IDataConnection connection)
    {
        this.connection = connection;
    }

    public ResultPage<WeatherForecast> GetForecasts(int pageSize, int pageNo)
    {
        // Verwende connection
        return new ResultPage<WeatherForecast>(0, 0, 0);
    }
}
