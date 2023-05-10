using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo
{
    public class Produto
    {
        public string nome { get; set; }

        public int codigo { get; set; }
        public float preco { get; set; }

        public Produto()
        {
        } 

        public Produto(string Nome, int Codigo, float Preco)
        { 
            codigo = Codigo;
            nome = Nome;
            preco = Preco;  
        }
    }
}