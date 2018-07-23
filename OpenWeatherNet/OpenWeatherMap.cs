using OpenWeatherNet.Forecasting;
using OpenWeatherNet.Models;
using System.Net;
using System.Threading.Tasks;

namespace OpenWeatherNet
{
    /// <summary>
    /// A .Net wrapper for the OpenWeatherMap api.
    /// </summary>
    public class OpenWeatherMap
    {
        private readonly string _urlBase = "http://api.openweathermap.org/data/2.5";
        private WebClient _client;
        private string _apiKey;
        private Units _unit;

        private string _unitString
        {
            get { return _unit.ToString().ToLower(); }
        }

        public OpenWeatherMap(string apiKey, Units unit = Units.Kelvin)
        {
            _client = new WebClient();
            _apiKey = apiKey;
            _unit = unit;
        }

        /// <summary>
        /// Get forecast by city (Use ByCityCode to avoid ambiguous results).
        /// </summary>
        /// <param name="cityName">City name.</param>
        /// <param name="countryCode">Country code (Use ISO 3166 country codes).</param>
        /// <returns></returns>
        public async Task<T> ByCityName<T>(string cityName, string countryCode) where T : ForecastBase
        {
            var json = await _client.DownloadStringTaskAsync($"{_urlBase}/{ApiTarget<T>()}?q={cityName},{countryCode}&appid={_apiKey}&units={_unitString}");
            return ForecastBase.FromJson<T>(json);
        }

        /// <summary>
        /// Get forecast by city.
        /// </summary>
        /// <param name="cityId">City code.</param>
        /// <returns></returns>
        public async Task<T> ByCityCode<T>(string cityId) where T : ForecastBase
        {
            var json = await _client.DownloadStringTaskAsync($"{_urlBase}/{ApiTarget<T>()}?id={cityId}&appid={_apiKey}&units={_unitString}");
            return ForecastBase.FromJson<T>(json);
        }

        /// <summary>
        /// Get forecast by geo graphical coordinates.
        /// </summary>
        /// <param name="lat">Coordinates in lattitude.</param>
        /// <param name="lon">Coordinates in Longitude.</param>
        /// <returns></returns>
        public async Task<T> ByCoord<T>(string lat, string lon) where T : ForecastBase
        {
            var json = await _client.DownloadStringTaskAsync($"{_urlBase}/{ApiTarget<T>()}?lat{lat}&lon={lon}&appid={_apiKey}&units={_unitString}");
            return ForecastBase.FromJson<T>(json);
        }

        /// <summary>
        /// Get forecast by ZIP code.
        /// </summary>
        /// <param name="zipCode">Zip code.</param>
        /// <param name="countryCode">Country code (Use ISO 3166 country codes).</param>
        /// <returns></returns>
        public async Task<T> ByZipCode<T>(string zipCode, string countryCode) where T : ForecastBase
        {
            var json = await _client.DownloadStringTaskAsync($"{_urlBase}/{ApiTarget<T>()}?zip={zipCode},{countryCode}&appid={_apiKey}&units={_unitString}");
            return ForecastBase.FromJson<T>(json);
        }

        //Checks the type, and returns a string value of the type name.
        private string ApiTarget<T>()
        {
            if (typeof(T) == typeof(Forecast))
                return "forecast";
            else
                return "weather";
        }
    }
}