using OpenWeatherNet;
using OpenWeatherNet.Converters;
using OpenWeatherNet.Forecasting;
using OpenWeatherNet.Models;
using System;

namespace SampleAPICall
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var openWeather = new OpenWeatherMap("TOKEN HERE", Units.Imperial);

            Console.WriteLine("Press any key to get forecast data...");
            Console.ReadKey();

            var currentWeather = openWeather.ByZipCode<CurrentWeather>("20439", "us").Result;
            Console.WriteLine(currentWeather.Weather[0].Description);
            Console.ReadKey();

            var forecast = openWeather.ByZipCode<Forecast>("20439", "us").Result;
            Console.WriteLine(forecast.ForecastCollection[0].Weather[0].Description);
            Console.ReadKey();

            var temp = currentWeather.DayMeasurements.Temp;
            Console.WriteLine(temp);


            Console.ReadKey();
        }
    }
}