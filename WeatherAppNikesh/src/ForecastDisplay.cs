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
        ///conditional switch statement which provides message if temperature is less than 10 degree, in between 10 to 20 and more than 20 degree
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
/// Additional Forecast message with the actual temperature of that day
        Console.WriteLine($"Forecast: {forecastMessage} because it's {temperature:F2}°C today.");
        Console.WriteLine();
    }
}
