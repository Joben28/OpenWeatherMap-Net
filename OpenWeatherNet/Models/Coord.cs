using Newtonsoft.Json;

namespace OpenWeatherNet.Models
{
    public sealed class Coord
    {
        /// <summary>
        /// City geo location, latitude.
        /// </summary>
        [JsonProperty("lat")]
        public double Lat { get; set; }

        /// <summary>
        /// City geo location, longitude.
        /// </summary>
        [JsonProperty("lon")]
        public double Lon { get; set; }
    }
}