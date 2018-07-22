using Newtonsoft.Json;

namespace OpenWeatherNet.Forecasting
{
    public partial class WeekMeasurements
    {
        /// <summary>
        /// Temperature in units of Kelvin. 
        /// (Use UnitConverter to convert to Metric or Imperial)
        /// </summary>
        [JsonProperty("temp")]
        public double Temp { get; set; }

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

        /// <summary>
        /// Atmospheric pressure on the sea level by default, hPa.
        /// </summary>
        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        /// <summary>
        /// Atmospheric pressure on the sea level, hPa.
        /// </summary>
        [JsonProperty("sea_level")]
        public double SeaLevel { get; set; }

        /// <summary>
        /// Atmospheric pressure on the ground level, hPa.
        /// </summary>
        [JsonProperty("grnd_level")]
        public double GrndLevel { get; set; }

        /// <summary>
        /// Humidity in %.
        /// </summary>
        [JsonProperty("humidity")]
        public long Humidity { get; set; }

        /// <summary>
        /// Internal parameter.
        /// </summary>
        [JsonProperty("temp_kf")]
        public double TempKf { get; set; }
    }
}