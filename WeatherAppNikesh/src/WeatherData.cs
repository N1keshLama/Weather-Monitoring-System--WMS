using System;
using System.Collections.Generic;

public class WeatherData
{
    private static WeatherData instance;
    private Random random;
    private double temperature;
    private double humidity;
    private double pressure;
    private List<IDisplay> displays;

    private WeatherData()
    {
        random = new Random();
        displays = new List<IDisplay>();
    }

    public static WeatherData Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new WeatherData();
            }
            return instance;
        }
    }

    public void UpdateWeatherData()
    {
        temperature = random.NextDouble() * 45 - 13;
        humidity = random.NextDouble() * 106;
        pressure = random.NextDouble() * 145 + 891;
        NotifyDisplays();
    }

    public void RegisterDisplay(IDisplay display)
    {
        displays.Add(display);
    }

    public void RemoveDisplay(IDisplay display)
    {
        displays.Remove(display);
    }

    private void NotifyDisplays()
    {
        foreach (var display in displays)
        {
            display.Display();
        }
    }

    public double GetTemperature()
    {
        return temperature;
    }

    public double GetHumidity()
    {
        return humidity;
    }

    public double GetPressure()
    {
        return pressure;
    }
}
