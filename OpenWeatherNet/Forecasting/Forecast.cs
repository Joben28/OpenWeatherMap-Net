using Newtonsoft.Json;
using OpenWeatherNet.Converters;
using OpenWeatherNet.Models;

namespace OpenWeatherNet.Forecasting
{
    /// <summary>
    /// Weather forecast for 5 days with data every 3 hours.
    /// </summary>
    public sealed class Forecast : ForecastBase
    {
        ///<summary>
        /// Internal 'code' parameter.
        ///</summary>
        [JsonProperty("cod")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Cod { get; set; }

        ///<summary>
        /// Internal 'message' parameter.
        /// </summary>
        [JsonProperty("message")]
        public double Message { get; set; }

        ///<summary>
        /// Number of lines returned by the API call.
        /// </summary>
        [JsonProperty("cnt")]
        public long Cnt { get; set; }

        ///<summary>
        /// Collection of 5 day / 3 hour forecast data.
        /// </summary>
        [JsonProperty("list")]
        public ForecastWeather[] ForecastCollection { get; set; }

        ///<summary>
        /// City of the forecast data.
        /// </summary>
        [JsonProperty("city")]
        public City City { get; set; }
    }
}