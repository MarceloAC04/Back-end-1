using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_end_1.POO.listas.ExercicioCarro
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }

        public Carro()
        {       
        }

        public Carro(string marca, string modelo, string cor)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Cor = cor;
        }
    }
}