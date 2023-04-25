using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelularPOO
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;

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

        public bool Ligar()
        {
            Console.WriteLine($"Deseja ligar o {modelo}? S/N");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S")
            {
                this.ligado = true;
            }
            else
            {
                this.ligado = false;
            }

            return this.ligado;

        }
        public bool Desligar()
        {
            Console.WriteLine($"Deseja desligar o {modelo}? S/N");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S")
            {
                this.ligado = false;
            }
            else
            {
                this.ligado = true;
            }

            return this.ligado;
        }
        public void FazerLigacao()
        {
           BarraCarregamento("Ligando", 5, 700);
        }
        public void EnviarMensagem()
        {
            BarraCarregamento("Enviando mensagem", 5, 700);
        }
    }
}