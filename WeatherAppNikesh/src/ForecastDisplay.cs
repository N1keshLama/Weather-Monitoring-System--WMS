public class ForecastDisplay : IDisplay
{
    private readonly WeatherData weatherData;

    public ForecastDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        this.weatherData.RegisterDisplay(this);
    }

    public void Display()
    {
        Console.WriteLine("Weather Forecast:");
        double temperature = weatherData.GetTemperature();

        string forecastMessage;
        if (temperature < 10)
        {
            forecastMessage = "Cool day!";
        }
        else if (temperature > 20)
        {
            forecastMessage = "Hot today!";
        }
        else
        {
            forecastMessage = "Nice weather!";
        }

        Console.WriteLine($"Forecast: {forecastMessage} because it's {temperature:F2}°C today.");
        Console.WriteLine();
    }
}
