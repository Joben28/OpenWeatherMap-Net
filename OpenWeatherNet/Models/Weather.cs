using Newtonsoft.Json;
using OpenWeatherNet.Converters;

namespace OpenWeatherNet.Models
{
    public partial class Weather
    {
        /// <summary>
        /// Weather condition id.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Group of weather parameters (Rain, Snow, Extreme etc.)
        /// </summary>
        [JsonProperty("main")]
        public MainEnum Main { get; set; }

        /// <summary>
        /// Weather condition within the group.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Weather icon id.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}