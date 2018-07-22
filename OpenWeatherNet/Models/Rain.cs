using Newtonsoft.Json;

namespace OpenWeatherNet.Models
{
    public partial class Rain
    {
        /// <summary>
        /// Rain/Snow volume for last 3 hours in milimeters.
        /// </summary>
        [JsonProperty("3h", NullValueHandling = NullValueHandling.Ignore)]
        public double? The3H { get; set; }
    }
}