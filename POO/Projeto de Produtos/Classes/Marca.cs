using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_Produtos.Classes
{
    public class Marca
    {
       private int Codigo { get; set; }
       private string NomeMarca { get; set; }
       private DateTime DataCadastro { get; set; }
       private List<Marca> ListaMarca = new List<Marca>();

        public string CadastrarMarca(Marca novaMarca)
        {
            Console.WriteLine($"Digite o código do Marca");
            this.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome do Marca");
            this.NomeMarca = Console.ReadLine();

            DataCadastro = DateTime.Now;

            ListaMarca.Add(novaMarca);

            return "Marca cadastrada";
        }

        public List<Marca> ListarMarca(Marca novaMarca)
        {
            foreach (var item in ListaMarca)
            {
                Console.WriteLine($"Nome: {item.NomeMarca}, Código: {item.Codigo}");
                Console.WriteLine($"Data de cadastro: {DataCadastro}");
            }

            return ListaMarca;
        }

        public string Deletar(Marca novaMarca)
        {
            int index = ListaMarca.IndexOf(novaMarca);
            ListaMarca.RemoveAt(index);

            return "Marca removida!";
        }
    }
}