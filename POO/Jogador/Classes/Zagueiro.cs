using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_end_1.POO.Jogador.Classes
{
    public class Zagueiro : Jogador
    {
        public override void Aposetadoria()
        {
            int aposetar = (40 - this.idade);
            if (aposetar > 0)
            {
                Console.WriteLine($"Falta {aposetar} ano(s) para o jogador {this.nome} se aposetar!");
            }
            else
            {
                Console.WriteLine($"O jogador {this.nome} está aposentado!");
            }
            Console.ReadKey();
        }
    }
}