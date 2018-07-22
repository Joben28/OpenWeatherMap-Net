using Newtonsoft.Json;
using OpenWeatherNet.Models;
using System;

namespace OpenWeatherNet.Converters
{
    internal class PodConverter : JsonConverter
    {
        public static readonly PodConverter Singleton = new PodConverter();

        public override bool CanConvert(Type t) => t == typeof(Pod) || t == typeof(Pod?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "d":
                    return Pod.Day;

                case "n":
                    return Pod.Night;
            }
            throw new Exception("Cannot unmarshal type Pod");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Pod)untypedValue;
            switch (value)
            {
                case Pod.Day:
                    serializer.Serialize(writer, "d");
                    return;

                case Pod.Night:
                    serializer.Serialize(writer, "n");
                    return;
            }
            throw new Exception("Cannot marshal type Pod");
        }
    }
}