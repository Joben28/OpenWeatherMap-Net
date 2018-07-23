using Newtonsoft.Json;

namespace OpenWeatherNet.Models
{
    public sealed class Clouds
    {
        /// <summary>
        /// Cloudiness in %.
        /// </summary>
        [JsonProperty("all")]
        public long All { get; set; }
    }
}