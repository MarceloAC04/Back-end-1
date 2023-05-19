using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_Produtos.Classes
{
    public class Usuario
    {
        private int Codigo { get; set; }
        public string Nome { get; set; }
        private string Email { get; set; }
        public string Senha { get; set; }
        private DateTime DataCadastro { get; set; }

        public void CadastrarUsuario(Usuario novoUsuario)
        {
            this.Nome = "MARCELO";
            this.Senha = "1234";
            this.DataCadastro = DateTime.Now;
        }

        public void DeletarUsuario(Usuario novoUsuario)
        {
           this.Nome = "";
           this.Senha = "";
           this.Email = "";
           this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }
    }
}