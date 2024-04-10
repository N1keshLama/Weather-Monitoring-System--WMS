public class WeatherStation
{
    private readonly WeatherData weatherData;

    public WeatherStation(WeatherData weatherData)
    {
        this.weatherData = weatherData;
    }

    public IDisplay CreateCurrentConditionsDisplay()
    {
        return new CurrentConditionsDisplay(weatherData);
    }

    public IDisplay CreateStatisticsDisplay()
    {
        return new StatisticsDisplay(weatherData);
    }

    public IDisplay CreateForecastDisplay()
    {
        return new ForecastDisplay(weatherData);
    }
}
