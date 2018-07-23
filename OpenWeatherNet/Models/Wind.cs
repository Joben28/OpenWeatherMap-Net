using Newtonsoft.Json;

namespace OpenWeatherNet.Models
{
    public sealed class Wind
    {
        /// <summary>
        /// Speed in Meters per second.
        /// </summary>
        [JsonProperty("speed")]
        public double Speed_Mps { get; set; }

        /// <summary>
        /// Wind direction in degrees (meteorological).
        /// </summary>
        [JsonProperty("deg")]
        public double Deg { get; set; }
    }
}