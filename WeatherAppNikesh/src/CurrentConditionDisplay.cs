public class CurrentConditionsDisplay : IDisplay
{
    private readonly WeatherData weatherData;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        this.weatherData.RegisterDisplay(this);
    }

    public void Display()
    {
        Console.WriteLine("Current Conditions:");
        Console.WriteLine($"Temperature: {weatherData.GetTemperature():F2}°C, " +
                          $"Humidity: {weatherData.GetHumidity():F2}%, " +
                          $"Pressure: {weatherData.GetPressure():F2} hPa");
        Console.WriteLine();
    }
}
