using Newtonsoft.Json;
using OpenWeatherNet.Models;
using System;

namespace OpenWeatherNet.Forecasting
{
    /// <summary>
    /// Forecast data containing date time, weather, and measurement information.
    /// </summary>
    public sealed class ForecastWeather
    {
        /// <summary>
        /// Time of data forecasted, unix, UTC.
        /// </summary>
        [JsonProperty("dt")]
        public long Dt { get; set; }

        /// <summary>
        /// Forecast measurements (Temperature, Humidity, etc.)
        /// </summary>
        [JsonProperty("main")]
        public ForecastMeasurements Measurements { get; set; }

        /// <summary>
        /// Weather conditions.
        /// </summary>
        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }

        /// <summary>
        /// Cloud conditions.
        /// </summary>
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        /// <summary>
        /// Wind conditions.
        /// </summary>
        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        /// <summary>
        /// Rain conditions.
        /// </summary>
        [JsonProperty("rain", NullValueHandling = NullValueHandling.Ignore)]
        public Rain Rain { get; set; }

        /// <summary>
        /// Snow conditions.
        /// </summary>
        [JsonProperty("snow", NullValueHandling = NullValueHandling.Ignore)]
        public Rain Snow { get; set; }

        /// <summary>
        /// Data/time of calculation, UTC.
        /// </summary>
        [JsonProperty("dt_txt")]
        public DateTimeOffset DtTxt { get; set; }

        [JsonProperty("sys")]
        public ForecastSys Sys { get; set; }
    }
}