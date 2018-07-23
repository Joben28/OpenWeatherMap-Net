using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherNet.Forecasting
{
    public sealed class CurrentMeasurements
    {
        /// <summary>
        /// Temperature in units of Kelvin. 
        /// (Use UnitConverter to convert to Metric or Imperial)
        /// </summary>
        [JsonProperty("temp")]
        public double Temp { get; set; }

        /// <summary>
        /// Atmospheric pressure on the sea level by default, hPa.
        /// </summary>
        [JsonProperty("pressure")]
        public long Pressure { get; set; }

        /// <summary>
        /// Humidity in %.
        /// </summary>
        [JsonProperty("humidity")]
        public long Humidity { get; set; }

        /// <summary>
        /// Minimum temperature at the moment of calculation in units of Kelvin.
        /// (Use UnitConverter to convert to Metric or Imperial)
        /// </summary>
        [JsonProperty("temp_min")]
        public double TempMin { get; set; }

        /// <summary>
        /// Maximum temperature at the moment of calculation in units of Kelvin.
        /// (Use UnitConverter to convert to Metric or Imperial)
        /// </summary>
        [JsonProperty("temp_max")]
        public double TempMax { get; set; }
    }
}
