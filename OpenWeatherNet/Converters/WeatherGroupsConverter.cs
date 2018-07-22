﻿using Newtonsoft.Json;
using OpenWeatherNet.Models;
using System;

namespace OpenWeatherNet.Converters
{
    internal class WeatherGroupsConverter : JsonConverter
    {
        public static readonly WeatherGroupsConverter Singleton = new WeatherGroupsConverter();

        public override bool CanConvert(Type t) => t == typeof(MainEnum) || t == typeof(MainEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Thunderstorm":
                    return MainEnum.Thunderstorm;

                case "Drizzle":
                    return MainEnum.Drizzle;

                case "Rain":
                    return MainEnum.Rain;

                case "Snow":
                    return MainEnum.Snow;

                case "Mist":
                    return MainEnum.Mist;

                case "Clear":
                    return MainEnum.Clear;

                case "Clouds":
                    return MainEnum.Clouds;

            }

            //Would throw exception, but still unsure if I have ALL possible values from documentation
            Console.WriteLine($"ERROR: No WeatherGroup exists for '{value}'. WeatherGroups.Unknown was returned.");
            return MainEnum.Unknown;
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MainEnum)untypedValue;
            switch (value)
            {
                case MainEnum.Thunderstorm:
                    serializer.Serialize(writer, "Thunderstorm");
                    return;

                case MainEnum.Drizzle:
                    serializer.Serialize(writer, "Drizzle");
                    return;

                case MainEnum.Rain:
                    serializer.Serialize(writer, "Rain");
                    return;

                case MainEnum.Snow:
                    serializer.Serialize(writer, "Snow");
                    return;

                case MainEnum.Mist:
                    serializer.Serialize(writer, "Mist");
                    return;

                case MainEnum.Clear:
                    serializer.Serialize(writer, "Clear");
                    return;

                case MainEnum.Clouds:
                    serializer.Serialize(writer, "Clouds");
                    return;
            }
            throw new Exception("Cannot marshal type WeatherGroups");
        }
    }
}