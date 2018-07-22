using Newtonsoft.Json;
using OpenWeatherNet.Models;

namespace OpenWeatherNet.Forecasting
{
    public partial class WeekSys
    {
        /// <summary>
        /// Part of day, day & night.
        /// </summary>
        [JsonProperty("pod")]
        public Pod Pod { get; set; }
    }
}