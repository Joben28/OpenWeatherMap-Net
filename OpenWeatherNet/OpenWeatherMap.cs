using OpenWeatherNet.Forecasting;
using OpenWeatherNet.Models;
using System.Net;

namespace OpenWeatherNet
{
    /// <summary>
    /// A .Net wrapper for the OpenWeatherMap api.
    /// </summary>
    public class OpenWeatherMap
    {
        private string _apiKey;

        public OpenWeatherMap(string apiKey)
        {
            _apiKey = apiKey;
        }

        /// <summary>
        /// Get forecast by city (Use ByCityCode to avoid ambiguous results).
        /// </summary>
        /// <param name="cityName">City name.</param>
        /// <param name="countryCode">Country code (Use ISO 3166 country codes).</param>
        /// <returns></returns>
        public T GetForecastByCityName<T>(string cityName, string countryCode) where T : Forecast
        {
            return Forecast.FromJson<T>(new WebClient()
                .DownloadString($"http://api.openweathermap.org/data/2.5/{ApiTarget<T>()}?q={cityName},{countryCode}&appid={_apiKey}"));
        }

        /// <summary>
        /// Get forecast by city.
        /// </summary>
        /// <param name="cityId">City code.</param>
        /// <returns></returns>
        public T GetForecastByCityCode<T>(string cityId) where T : Forecast
        {
            return Forecast.FromJson<T>(new WebClient()
                .DownloadString($"http://api.openweathermap.org/data/2.5/{ApiTarget<T>()}?id={cityId}&appid={_apiKey}"));
        }

        /// <summary>
        /// Get forecast by geo graphical coordinates.
        /// </summary>
        /// <param name="lat">Coordinates in lattitude.</param>
        /// <param name="lon">Coordinates in Longitude.</param>
        /// <returns></returns>
        public T GetForecastByCoord<T>(string lat, string lon) where T : Forecast
        {
            return Forecast.FromJson<T>(new WebClient()
                .DownloadString($"http://api.openweathermap.org/data/2.5/{ApiTarget<T>()}?lat{lat}&lon={lon}&appid={_apiKey}"));
        }

        /// <summary>
        /// Get forecast by ZIP code.
        /// </summary>
        /// <param name="zipCode">Zip code.</param>
        /// <param name="countryCode">Country code (Use ISO 3166 country codes).</param>
        /// <returns></returns>
        public T GetForecastByZipCode<T>(string zipCode, string countryCode) where T : Forecast
        {
            return Forecast.FromJson<T>(new WebClient()
                .DownloadString($"http://api.openweathermap.org/data/2.5/{ApiTarget<T>()}?zip={zipCode},{countryCode}&appid={_apiKey}"));
        }

        private string ApiTarget<T>()
        {
            if (typeof(T) == typeof(WeekForecast))
                return "forecast";
            else
                return "weather";
        }
    }
}