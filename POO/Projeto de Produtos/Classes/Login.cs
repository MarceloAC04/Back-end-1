using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_Produtos.Classes
{
    public class Login
    {
        private bool logado { get; set; }
        private string user { get; set; }

        public string sen { get; set; }

        private Usuario usuario = new Usuario();
        public Login()
        {
            usuario.Cadastrar(usuario);
            do
            {
                Console.WriteLine($"Digite o nome do usuário");
                this.user = Console.ReadLine().ToUpper();
                Console.WriteLine($"Digite a sua senha");
                this.sen = Console.ReadLine();
                if (user == usuario.Nome && sen == usuario.Senha)
                {
                    Console.WriteLine($"Acesso consetido");
                    Logar(usuario);
                    GerarMenu(this.logado);
                }
                else
                {
                    Console.WriteLine($"Acesso negado!");
                    Console.WriteLine($"Digite as informações novamente!");
                }
            } while (user != usuario.Nome || sen != usuario.Senha);

        }

        public void Logar(Usuario usuario)
        {
            this.logado = true;
        }
        public void Deslogado(Usuario usuario)
        {
            this.logado = false;
        }

        public void GerarMenu(bool logado)
        {
            Produto produto = new Produto();

            Marca Marca = new Marca();


            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@$"
    -----------------------------------
    |      Projeto do demoninho       |
    | [1] - Cadastrar Produto         |
    | [2] - Listar Produtos           |
    | [3] - Deletar Produto           |
    | [4] - Cadastrar Marca           |
    | [5] - Listar Marcas             |
    | [6] - Deletar Produtos          |
    | [0] - Deslogar                  |
    ----------------------------------
    ");
                Console.ResetColor();
                Console.WriteLine($"Escolha uma opção");
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "0":
                        Deslogado(usuario);
                        break;
                    case "1":
                        produto.CadastrarProduto();
                        break;
                    case "2":
                        produto.ListarProduto();
                        break;
                    case "3":
                        produto.DeletarProduto();
                        break;
                    case "4":
                        Marca.CadastrarMarca();
                        break;
                    case "5":
                        Marca.ListarMarca();
                        break;
                    case "6":
                        // Marca.Deletar();
                        break;
                    default:
                        Console.WriteLine($"Opção inválida");
                        Console.ReadKey();
                        break;
                }

            } while (this.logado);
        }

    }
}