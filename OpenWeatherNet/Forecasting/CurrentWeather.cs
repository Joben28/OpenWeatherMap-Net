using Newtonsoft.Json;
using OpenWeatherNet.Converters;
using OpenWeatherNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherNet.Forecasting
{
    /// <summary>
    /// Current weather for the geo graphical area.
    /// </summary>
    public sealed class CurrentWeather : ForecastBase
    {
        /// <summary>
        /// City geo location by lattitude & longitude.
        /// </summary>
        [JsonProperty("coord")]
        public Coord Coord { get; set; }

        /// <summary>
        /// Weather conditions.
        /// </summary>
        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }

        /// <summary>
        /// Forecast measurements (Temperature, Humidity, etc.)
        /// </summary>
        [JsonProperty("main")]
        public CurrentMeasurements DayMeasurements { get; set; }

        /// <summary>
        /// Wind conditions.
        /// </summary>
        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        /// <summary>
        /// Cloud conditions.
        /// </summary>
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        /// <summary>
        /// Time of data forecasted, unix, UTC.
        /// </summary>
        [JsonProperty("dt")]
        public long Dt { get; set; }

        /// <summary>
        /// Information regarding sunrise/sunset.
        /// </summary>
        [JsonProperty("sys")]
        public CurrentSys Sys { get; set; }

        /// <summary>
        /// City id.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// City name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Internal 'code' parameter.
        /// </summary>
        [JsonProperty("cod")]
        public long Cod { get; set; }

        [JsonProperty("visibility")]
        public long Visibility { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }
    }
}
