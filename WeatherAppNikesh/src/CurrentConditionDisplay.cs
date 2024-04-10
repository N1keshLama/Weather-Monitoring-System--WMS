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
        /// Fetching Temperature, Humidity and Pressure from WeatherData and displaying data after 2 decimal places
        Console.WriteLine($"Temperature: {weatherData.GetTemperature():F2}°C, " +
                          $"Humidity: {weatherData.GetHumidity():F2}%, " +
                          $"Pressure: {weatherData.GetPressure():F2} hPa");
        Console.WriteLine();
    }
}
