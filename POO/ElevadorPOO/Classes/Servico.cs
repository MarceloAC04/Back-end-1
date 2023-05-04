using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevadorPOO.Classes
{
    public class Servico : Elevador
    {
        private int caixas { get; set; }
        private int totalCaixas {get; set;}
        public void ElevadorServico(int capacidade, int totalAndares, int totalCaixas)
        {
            Console.WriteLine($"O elevador comporta {totalCaixas} caixas!");
            this.caixas = 0;
        }

         public int Colocar()
        {
            Console.WriteLine($"Quantas caixas vão entrar ?");
            int caixasEntrando = int.Parse(Console.ReadLine());
            this.caixas = this.caixas + caixasEntrando;
            if (this.caixas < this.totalCaixas)
            {
                Console.WriteLine($"Entrando {this.caixas} caixas!");

            }
            else
            {
                Console.WriteLine($"Elevador está lotado de caixas !");

            }
            return caixas;
            Console.ReadKey();
        }
         public int Retirar()
        {
            Console.WriteLine($"Quantas caixas vão sair ?");
            int caixasSaindo = int.Parse(Console.ReadLine());
            this.caixas = this.caixas + caixasSaindo;
            if (this.caixas > 0)
            {
                Console.WriteLine($"Saindo {this.caixas} caixas!");

            }
            else
            {
                Console.WriteLine($"Elevador não tem vazio!");

            }
            return caixas;
            Console.ReadKey();
        }


    }
}