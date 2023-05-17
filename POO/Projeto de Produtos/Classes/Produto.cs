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

         Marca marca = new Marca();

        public List<Produto> ListaDeProduto = new List<Produto>();

        public void CadastrarProduto()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Digite o nome do produto");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Digite o preço do produto");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o código do produto");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            novoProduto.DataCadastro = DateTime.Now;

            ListaDeProduto.Add(novoProduto);

            marca.CadastrarMarca();

            novoProduto.CadastradoPor = new Usuario();
            
        }

        public void ListarProduto()
        {
            foreach (Produto item in ListaDeProduto)
            {
                Console.WriteLine($"Nome: {item.NomeProduto}, Código: {item.Codigo}, Preço: {item.Preco}");
                item.CadastradoPor.Cadastrar(CadastradoPor);
                Console.WriteLine(@$"
                Data de cadastro: {item.DataCadastro}
                Cadastrado por: {item.CadastradoPor.Nome}
                ");
            }

        }

        public void DeletarProduto()
        {
            Produto produtoDeletar = new Produto();
            Console.WriteLine($"Insira o código do produto que queira remover");
            int codigo = int.Parse(Console.ReadLine());
            produtoDeletar = ListaDeProduto.Find(p => p.Codigo == codigo)!;
            ListaDeProduto.Remove(produtoDeletar);

        }

    }
}