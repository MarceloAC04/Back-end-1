using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora
{
    public class Calculadora
    {
       public float Somar(float n1, float n2)
        {
            return (n1 + n2);
        }
       public float Subtrair(float n1, float n2)
        {
            return (n1 - n2);
        }
       public float Multiplicar(float n1, float n2)
        {
            return (n1 * n2);
        }
       public float Dividir(float n1, float n2)
        {
            return (float)Math.Round(n1 / n2,2);
        }
    }
}