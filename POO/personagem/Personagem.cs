using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personagem
{
    public class Personagem
    {
        public string nome;

        public int idade;

        public string armadura;

        public string ia;
        public void Atacar()
        {
            Console.WriteLine($"O personagem atacou!");
            
        }

        public string Defendeu()
        {
            return "O personagem defendeu!";
        }

        public void RestaurarArmadura()
        {
            Console.WriteLine($"O personagem restaurou a armadura!");
            
        }
    }

}