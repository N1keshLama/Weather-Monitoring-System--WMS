using System;
using System.Collections.Generic;
using System.Linq;

public class StatisticsDisplay : IDisplay
{
    private readonly WeatherData weatherData;
    private List<double> temperatureReadings;

    public StatisticsDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        this.temperatureReadings = new List<double>();
        this.weatherData.RegisterDisplay(this);
    }

    public void Update(double temperature, double humidity, double pressure)
    {
        temperatureReadings.Add(temperature);
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Weather Statistics:");

        if (temperatureReadings.Count > 0)
        {
            double averageTemperature = temperatureReadings.Average();
            double maxTemperature = temperatureReadings.Max();
            double minTemperature = temperatureReadings.Min();

            Console.WriteLine($"Average Temperature: {averageTemperature:F2}°C");
            Console.WriteLine($"Max Temperature: {maxTemperature:F2}°C");
            Console.WriteLine($"Min Temperature: {minTemperature:F2}°C");
        }
        else
        {
            Console.WriteLine("No temperature readings available");
        }

        Console.WriteLine();
    }
}
