using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_end_1.POO.caféTabajara
{
    public class MaquinaCafe
    {
        public float acucarDisponivel;
        public void BarraCarregamento(string texto, int pontos, int tempo)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(texto);

            for (int i = 0; i < pontos; i++)
            {
                Console.Write($".");
                Thread.Sleep(tempo);
            }
            Console.ResetColor();
            Console.WriteLine($"");
        }


        public float FazerCafe(float acucarDisponivel)
        {
            Console.WriteLine($"Quanto gramas de açúcar deseja colocar no café");
            float acucar = float.Parse(Console.ReadLine());
            if (this.acucarDisponivel - acucar > 0)
            {
                BarraCarregamento($"Fazendo o café com {acucar} gramas de açúcar", 5, 600);
                this.acucarDisponivel = (this.acucarDisponivel - acucar);

            }
            else
            {
                Console.WriteLine($"Sem açúcar suficiente");
                BarraCarregamento($"Fazendo café sem açucar", 5, 300);
            }
            Console.ReadKey();
            return this.acucarDisponivel;
        }
        public float FazerCafe()
        {
            if (acucarDisponivel > 0)
            {
                BarraCarregamento($"Fazendo o café", 5, 600);
                this.acucarDisponivel = (this.acucarDisponivel - 10);

            }
            else
            {
                Console.WriteLine($"Sem açúcar suficiente");
                BarraCarregamento($"Fazendo café sem açucar", 5, 300);
            }
            Console.ReadKey();
            return this.acucarDisponivel;
        }

        public void acucarMaquina()
        {
            BarraCarregamento("Calculando",5,250);
            Console.WriteLine($"Tem {this.acucarDisponivel} gramas açúcar na máquina!");
            Console.ReadKey();
        }
    }
}