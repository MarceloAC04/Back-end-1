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
            Console.WriteLine($"O {modelo} está desligado, deseja ligar o celular? S/N");
            string resposta = Console.ReadLine().ToUpper();
            do
            {
                if (resposta == "S")
                {
                    this.ligado = true;
                    BarraCarregamento("Ligando", 5, 200);
                }
                else
                {
                    this.ligado = false;
                }
            } while (resposta != "S" && resposta != "N");
            return this.ligado;
        }
        public bool Desligar()
        {
            Console.WriteLine($"Deseja desligar o {modelo}? S/N");
            string resposta = Console.ReadLine().ToUpper();
            do
            {
                if (resposta == "S")
                {
                    this.ligado = false;
                    BarraCarregamento("Desligando", 5, 200);
                }
                else
                {
                    this.ligado = true;
                }
            } while (resposta != "S" && resposta != "N");
            return this.ligado;
        }
        public void FazerLigacao()
        {
            BarraCarregamento("Fazendo ligação", 5, 700);
        }
        public void EnviarMensagem()
        {
            BarraCarregamento("Enviando mensagem", 5, 700);
        }
    }
}