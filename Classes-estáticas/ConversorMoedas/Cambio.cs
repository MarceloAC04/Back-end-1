using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConversorMoedas
{
    public static class Cambio
    {
        public static float cambio { get; set; }

        public static string RealParaDolar(float cambioDolar)
        {
            cambio = cambioDolar;

             float dolar = (cambio / 5);

             return dolar.ToString("C2", new CultureInfo("en-US"));
        }

        public static string DolarParaReal(float cambioReal)
        {
            cambio = cambioReal;

            float real = (cambio * 5);

            return real.ToString("C2");
        }
    }
}