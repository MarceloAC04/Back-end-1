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

        public List<Produto> ListaDeProduto = new List<Produto>();

        public Marca marca = new Marca();
        public void CadastrarProduto()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Digite o nome do produto");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Digite o preço do produto");
            novoProduto.Preco = float.Parse(Console.ReadLine());
            while (novoProduto.Preco < 0)
            {
                Console.WriteLine($"Digite um preço válido!");
                novoProduto.Preco = float.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Digite o código do produto");
            novoProduto.Codigo = int.Parse(Console.ReadLine());
            while (novoProduto.Codigo <= 0)
            {
                Console.WriteLine($"Digite um código válido!");
                novoProduto.Codigo = int.Parse(Console.ReadLine());
            }

            novoProduto.DataCadastro = DateTime.Now;

            ListaDeProduto.Add(novoProduto);
            Console.WriteLine("===============");

            marca.Cadastrar();

            novoProduto.CadastradoPor = new Usuario();

        }

        public void ListarProduto()
        {
            if (ListaDeProduto.Count > 0)
            {
                foreach (Produto item in ListaDeProduto)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Nome: {item.NomeProduto}, Código: {item.Codigo}, Preço: {item.Preco:C}");
                    item.CadastradoPor.CadastrarUsuario(item.CadastradoPor);
                    Console.WriteLine($"Data de cadastro: {item.DataCadastro}, Cadastrado por: {item.CadastradoPor.Nome}");
                    Console.WriteLine($"==============================================================");
                    
                    Console.ResetColor();
                }
                Console.WriteLine($"Aperte enter para sair");
                Console.ReadKey();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"A lista de produtos está vazia!");
                Console.ResetColor();
                Console.WriteLine($"Aperte enter para sair");
                Console.ReadKey();
            }

        }


        public void DeletarProduto()
        {
            if (ListaDeProduto.Count > 0)
            {
                Produto produtoDeletar = new Produto();
                Console.WriteLine($"Insira o código do produto que queira remover");
                int codigo = int.Parse(Console.ReadLine());
                produtoDeletar = ListaDeProduto.Find(p => p.Codigo == codigo)!;
                ListaDeProduto.Remove(produtoDeletar);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"A lista de produtos está vazia!");
                Console.ResetColor();
                Console.WriteLine($"Aperte enter para sair");
                Console.ReadKey();
            }

        }
        public void ListarMarca()
        {
            marca.Listar();
        }
        public void CadastrarMarca()
        {
            marca.Cadastrar();
        }
        public void DeletarMarca()
        {
            marca.Deletar();
        }

    }
}