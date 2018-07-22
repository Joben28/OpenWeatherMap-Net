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
            var openWeather = new OpenWeatherMap("TOKEN HERE");

            Console.WriteLine("Press any key to get forecast data...");
            Console.ReadKey();

            var dayForecast = openWeather.GetForecastByZipCode<DayForecast>("20439", "us");
            Console.WriteLine(dayForecast.Weather[0].Description);
            Console.ReadKey();

            var weekForecast = openWeather.GetForecastByZipCode<WeekForecast>("20439", "us");
            Console.WriteLine(weekForecast.ForecastCollection[0].Weather[0].Description);


            Console.ReadKey();
        }
    }
}