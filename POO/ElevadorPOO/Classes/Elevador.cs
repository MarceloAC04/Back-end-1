using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevadorPOO.Classes
{
    public abstract class Elevador
    {
       public int andarAtual {get; set;}
       public int totalAndares {get; set;}

        public int capacidade {get; set;}

       public int pessoasPresentes {get; set;}

        public void Inicializar(int capacidade, int totalAndares)
        {
            Console.WriteLine($"O elevador comporta o total de {capacidade} pessoas");
            Console.WriteLine($"O prédio possue {totalAndares} andares");
            Console.ReadKey();
        }

        public int Entrar()
        {
            Console.WriteLine($"Quantas pessoas vão entrar?");
            int pessoasEntrando = int.Parse(Console.ReadLine());
            this.pessoasPresentes = this.pessoasPresentes + pessoasEntrando;
            if (this.pessoasPresentes < capacidade)
            {
                Console.WriteLine($"Entrando {this.pessoasPresentes} pessoas!");

            }
            else
            {
                Console.WriteLine($"Elevador está lotado!");
            }
            return pessoasPresentes;
            Console.ReadKey();
        }
        public int Sair()
        {
            Console.WriteLine($"Quantas pessoas vão sair ?");
            int pessoasSaindo = int.Parse(Console.ReadLine());
            this.pessoasPresentes = this.pessoasPresentes + pessoasSaindo;
            if (this.pessoasPresentes > 0)
            {
                Console.WriteLine($"Saindo {this.pessoasPresentes} pessoas!");

            }
            else
            {
                Console.WriteLine($"Elevador já está vazio!");

            }
            return pessoasPresentes;
            Console.ReadKey();
        }
        public int Subir()
        {
            Console.WriteLine($"Para qual andar vai subir ?");
            this.andarAtual = int.Parse(Console.ReadLine());
            if (this.andarAtual < totalAndares)
            {
                Console.WriteLine($"Subindo para o {this.andarAtual}º andar!");

            }
            else
            {
                Console.WriteLine($"Andar inexistente!");

            }
            return andarAtual;
            Console.ReadKey();
        }
        public int Descer()
        {
            Console.WriteLine($"Para qual andar vai descer?");
            this.andarAtual = int.Parse(Console.ReadLine());
            if (this.andarAtual > 0)
            {
                Console.WriteLine($"Descendo para o {this.andarAtual}º andar!");

            }
            else
            {
                Console.WriteLine($"Andar inexistente!");
            }
            return andarAtual;
            Console.ReadKey();
        }
    }

}