using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_de_Produtos.Classes;

namespace Projeto_de_Produtos.Classes
{
    public class Produto
    {
        private int Codigo { get; set; }
        private string NomeProduto { get; set; }
        private float Preco { get; set; }
        private Usuario CadastradoPor { get; set; }
        private DateTime DataCadastro { get; set; }
        private Marca Marca { get; set; }
        private List<Produto> ListaDeProduto = new List<Produto>();

        public string CadastrarProduto(Produto novoProduto)
        {
            Console.WriteLine($"Digite o nome do produto");
            this.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Digite o preço do produto");
            this.Preco = float.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o código do produto");
            this.Codigo = int.Parse(Console.ReadLine());

            novoProduto.DataCadastro = DateTime.Now;

            ListaDeProduto.Add(novoProduto);

            return "Produto cadastrado";
        }

        public List<Produto> ListarProduto(Produto novoProduto)
        {
            foreach (var item in ListaDeProduto)
            {
                Console.WriteLine($"Nome: {item.NomeProduto}, Código: {item.Codigo}, Preço: {item.Preco}");
                Console.WriteLine($"Data de cadastro: {novoProduto.DataCadastro}"); 
            }

            return ListaDeProduto;
        }

        public string DeletarProduto(Produto novoProduto)
        {
            int index = ListaDeProduto.IndexOf(novoProduto);
            ListaDeProduto.RemoveAt(index);

            return "Produto removido!";
        }

    }
}