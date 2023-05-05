using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevadorPOO.Classes
{
    public class Elevador
    {
        public int andarAtual = 0;
        public int totalAndares { get; set; }

        public int capacidade { get; set; }

        public int pessoasPresentes { get; set; }

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
                Console.WriteLine($"Entrando {pessoasEntrando} pessoas!");

            }
            else
            {
                Console.WriteLine($"Elevador está lotado!");
            }
            Console.ReadKey();
            return pessoasPresentes;
        }
        public int Sair()
        {
            Console.WriteLine($"Quantas pessoas vão sair ?");
            int pessoasSaindo = int.Parse(Console.ReadLine());
            this.pessoasPresentes = this.pessoasPresentes - pessoasSaindo;
            if (this.pessoasPresentes > 0)
            {
                Console.WriteLine($"Saindo {pessoasSaindo} pessoas!");

            }
            else
            {
                Console.WriteLine($"Elevador já está vazio!");

            }
            Console.ReadKey();
            return pessoasPresentes;
        }
        public int Subir()
        {
            Console.WriteLine($"Para qual andar vai subir ?");
            int andarSubir = int.Parse(Console.ReadLine());
             if (this.andarAtual == andarSubir)
            {
                Console.WriteLine($"O elevador já está no {andarSubir}º andar");

            }
            else if (andarSubir < totalAndares && andarAtual != andarSubir)
            {
                Console.WriteLine($"Subindo para {andarSubir}º andar");
                this.andarAtual = andarSubir;
            }
            else
            {
                Console.WriteLine($"Elevador não pode subir");
            }
            Console.ReadKey();
            return andarAtual;
        }
        public int Descer()
        {
            Console.WriteLine($"Para qual andar vai descer?");
            int andarDescer = int.Parse(Console.ReadLine());
             if (this.andarAtual == andarDescer)
            {
                Console.WriteLine($"O elevador já está no {andarDescer}º andar");

            }
            if (andarDescer < totalAndares && andarAtual != andarDescer)
            {
                Console.WriteLine($"Descendo para {andarDescer}º andar");
                this.andarAtual = andarDescer;
            }
            else
            {
                Console.WriteLine($"Elevador não pode descer");
            }
            Console.ReadKey();
            return andarAtual;
        }

        public void Info()
        {
            if (this.andarAtual > 0)
            {
                Console.WriteLine($"O elevador está no {this.andarAtual}º andar");
            }
            else
            {
                Console.WriteLine($"O elevador está no térreo ");
            }

            if (this.pessoasPresentes > 0)
            {
                Console.WriteLine($"O elevador tem {this.pessoasPresentes} pessoas");
            }
            else
            {
                Console.WriteLine($"O elevador tem 0 pessoas");
            }
            Console.ReadKey();
        }
    }

}