using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_end_1.POO.Jogador.Classes
{
    public abstract class Jogador
    {
        public int idade;
        public string nome;
        public int dataNascimento;
        public string nacionalidade;
        public float peso;
        public float altura;

        public void Perfil()
        {
            Console.WriteLine(@$"
            Nome  do  jogador: {this.nome}
            Data de nascimento: {this.dataNascimento}
            Nacionalidade : {this.nacionalidade}
            Altura: {this.altura} M
            Peso: {this.peso} Kg
            ");
            Console.WriteLine($"Aperte enter para sair");
            Console.ReadKey();
        }
        public int IdadeJogador()
        {
            int anoAtual = DateTime.Now.Year;
            this.idade = (anoAtual - this.dataNascimento);
            Console.WriteLine($"A idade do jogador {this.nome} é {this.idade} anos");
            Console.WriteLine($"Aperte enter para sair");
            Console.ReadKey();
            return idade;
        }
        public abstract void Aposetadoria();

    }
}