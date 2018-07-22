using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace OpenWeatherNet.Converters
{
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                PodConverter.Singleton,
                WeatherGroupsConverter.Singleton,
                WeatherGroupsConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}