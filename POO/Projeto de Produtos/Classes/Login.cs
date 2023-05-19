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
            usuario.CadastrarUsuario(usuario);
            do
            {
                Console.WriteLine($"Digite o nome do usuário");
                this.user = Console.ReadLine().ToUpper();
                Console.WriteLine($"Digite a sua senha");
                this.sen = Console.ReadLine();
                if (user == usuario.Nome && sen == usuario.Senha)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Acesso consetido");
                    Console.ResetColor();
                    Logar(usuario);
                    GerarMenu(this.logado);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Acesso negado!");
                    Console.WriteLine($"Digite as informações novamente!");
                    Console.ResetColor();
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

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@$"
    -----------------------------------
    |      Projeto Produtos           |
    | [1] - Cadastrar Produto         |
    | [2] - Listar Produtos           |
    | [3] - Deletar Produto           |
    | [4] - Cadastrar Marca           |
    | [5] - Listar Marcas             |
    | [6] - Deletar Marcas            |
    | [7] - Cadastrar Usuário         |
    | [8] - Deletar Usuário           |
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
                        Console.ForegroundColor = ConsoleColor.White;
                        produto.CadastrarProduto();
                        Console.ResetColor();
                        Console.Clear();
                        break;
                    case "2":
                        produto.ListarProduto();
                        Console.Clear();
                        break;
                    case "3":
                        produto.DeletarProduto();
                        Console.Clear();
                        break;
                    case "4":
                        produto.CadastrarMarca();
                        Console.Clear();
                        break;
                    case "5":
                        produto.ListarMarca();
                        Console.Clear();
                        break;
                    case "6":
                        produto.DeletarMarca();
                        Console.Clear();
                        break;
                    case "7":
                        usuario.CadastrarUsuario(usuario);
                        Console.Clear();
                        break;
                    case "8":
                        usuario.DeletarUsuario(usuario);
                        Console.Clear();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Opção inválida");
                        Console.ResetColor();
                        Console.WriteLine($"Aperte enter para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (this.logado);
        }

    }
}