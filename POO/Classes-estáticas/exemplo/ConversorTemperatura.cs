using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo
{
    public static class ConversorTemperatura
    {

        public static float temperatura { get; set; }

        public static float CelsiusParaFahrenheit(float temperaturaCelsius)
        {
            temperatura = temperaturaCelsius;

             float fahrenheit = (float)Math.Round((temperaturaCelsius * 1.8f) + 32,2);

             return fahrenheit;
        }

        public static float FahrenheitParaCelsius(float temperaturaFahrenheit)
        {
            temperatura = temperaturaFahrenheit;

            float celsius = (float)Math.Round((temperatura - 32)*0.55f,2);

            return celsius;
        }
    }
}