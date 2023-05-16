using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_Produtos.Classes
{
    public class Usuario
    {
        private int Codigo { get; set; }
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Senha { get; set; }
        private DateTime DataCadastro { get; set; }

        private List<Usuario> ListaUsuario = new List<Usuario>();

        public string Cadastrar(Usuario novoUsuario)
        {
            Console.WriteLine($"Digite o nome do usuário");
            this.Nome = Console.ReadLine();

            Console.WriteLine($"Digite o email do usuário");
            this.Email = Console.ReadLine();

            Console.WriteLine($"Digite a senha do usuário");
            this.Senha = Console.ReadLine();

            Console.WriteLine($"Digite o código do usuário");
            this.Codigo = int.Parse(Console.ReadLine());

            return "Usuário cadastrado";
        }

        public string Deletar(Usuario novoUsuario)
        {
            return "Usuário cadastrado";
        }
    }
}