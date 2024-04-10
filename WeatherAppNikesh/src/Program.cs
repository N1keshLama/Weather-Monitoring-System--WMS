using System;

class Program
{
    static void Main(string[] args)
    {
        WeatherData weatherData = WeatherData.Instance;

        IDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
        IDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
        IDisplay forecastDisplay = new ForecastDisplay(weatherData);

        weatherData.UpdateWeatherData();

        Console.WriteLine("Weather Monitoring System:");
        Console.WriteLine("=========================");
        currentDisplay.Display();
        statisticsDisplay.Display();
        forecastDisplay.Display();
    }
}
