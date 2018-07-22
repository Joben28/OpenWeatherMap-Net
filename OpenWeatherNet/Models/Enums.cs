namespace OpenWeatherNet.Models
{
    /// <summary>
    /// Part of day, day & night.
    /// </summary>
    public enum Pod { Day, Night };

    /// <summary>
    /// Main weather parametes (Clear, Clouds, Rain).
    /// </summary>
    public enum MainEnum { Unknown, Thunderstorm, Drizzle, Rain, Snow, Mist, Clear, Clouds };

    /// <summary>
    /// Unit of measurements.
    /// </summary>
    public enum Units { Kelvin, Metric, Imperial };

    /// <summary>
    /// Type of forecast.
    /// </summary>
    public enum ForecastType { Weekly, Daily };
}