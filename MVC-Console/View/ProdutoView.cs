using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Console.Model;

namespace MVC_Console.View
{
    public class ProdutoView
    {
        // criar um metodo para exibir os dados da lista de produtos

        public void Listar(List<Produto> produto)
        {
            Console.Clear();
            //foreach para ler a lista passada como um parametro do metodo
            foreach (var item in produto)
            {
                Console.WriteLine($"\nCódigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C}");
            }

        }
    }
}