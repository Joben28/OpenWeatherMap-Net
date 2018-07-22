using OpenWeatherNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherNet.Converters
{
    public static class UnitConverter
    {
        public static double KelvinToFarenheit(double kelvins)
        {
            return (kelvins - 273.15) * 1.8 + 32;
        }

        public static double KelvinToCelsius(double kelvins)
        {
            return kelvins - 273.15;
        }
    }
}
