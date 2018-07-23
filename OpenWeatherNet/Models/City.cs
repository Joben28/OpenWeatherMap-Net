using Newtonsoft.Json;

namespace OpenWeatherNet.Models
{
    public sealed class City
    {
        /// <summary>
        /// City ID.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// City name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// City geo location by lattitude & longitude.
        /// </summary>
        [JsonProperty("coord")]
        public Coord Coord { get; set; }

        /// <summary>
        /// Country code (GB, JP etc.)
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}