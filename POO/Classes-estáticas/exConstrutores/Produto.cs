using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exConstrutores
{
    public class Produto
    {
        public string nome { get; set; }

        public int codigo { get; set; }
        public int estoque { get; set; }

        public Produto()
        {
            
        }

        public Produto(int Codigo)
        {
            codigo = Codigo;
        }

        public Produto(string Nome , int Codigo, int Estoque)
        {
            nome = Nome;
            codigo = Codigo;
            estoque = Estoque;
            
        }
    }
}