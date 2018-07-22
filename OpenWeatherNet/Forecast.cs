using Newtonsoft.Json;
using OpenWeatherNet.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherNet
{
    public abstract class Forecast
    {
        /// <summary>
        /// Gets Forecast object for json string.
        /// </summary>
        /// <param name="json">Serialized json.</param>
        /// <returns>Deserialized Forecast Object.</returns>
        public static T FromJson<T>(string json) => JsonConvert.DeserializeObject<T>(json, Converter.Settings);
    }
}
