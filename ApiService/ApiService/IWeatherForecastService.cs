namespace ApiService;

public interface IWeatherForecastService
{
    ResultPage<WeatherForecast> GetForecasts(int pageSize=100, int pageNo=0);
}