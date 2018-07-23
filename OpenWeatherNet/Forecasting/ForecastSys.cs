using Newtonsoft.Json;
using OpenWeatherNet.Models;

namespace OpenWeatherNet.Forecasting
{
    public sealed class ForecastSys
    {
        /// <summary>
        /// Part of day, day & night.
        /// </summary>
        [JsonProperty("pod")]
        public Pod Pod { get; set; }
    }
}