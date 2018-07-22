using Newtonsoft.Json;

namespace OpenWeatherNet.Models
{
    public partial class Wind
    {
        /// <summary>
        /// Speed in Meters per second.
        /// </summary>
        [JsonProperty("speed")]
        public double Speed_Mps { get; set; }

        /// <summary>
        /// Speed in Miles per hour.
        /// </summary>
        public double Speed_Mph
        {
            get { return Speed_Mps * 2.2369; }
        }

        /// <summary>
        /// Wind direction in degrees (meteorological).
        /// </summary>
        [JsonProperty("deg")]
        public double Deg { get; set; }
    }
}