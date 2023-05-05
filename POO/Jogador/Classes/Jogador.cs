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
            Data de nasciemnto: {this.dataNascimento}
            Nacionalidade : {this.nacionalidade}
            Altura: {this.nacionalidade}
            Peso: {this.peso}
            ");
        }
        public void IdadeJogador()
        {

        }
    }
}