using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_Produtos.Classes
{
    public class Marca
    {
       public int Codigo { get; set; }
       public string NomeMarca { get; set; }
       private DateTime DataCadastro { get; set; }
       public List<Marca> ListaDeMarca = new List<Marca>();

        public Marca CadastrarMarca()
        {
            Marca novaMarca = new Marca();

            Console.WriteLine($"Digite o código do Marca");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome do Marca");
            novaMarca.NomeMarca = Console.ReadLine();

            novaMarca.DataCadastro = DateTime.Now;

            ListaDeMarca.Add(novaMarca);

            return novaMarca;
        }

        public void ListarMarca()
        {
            foreach (Marca item in ListaDeMarca)
            {
                Console.WriteLine($"Nome: {item.NomeMarca}, Código: {item.Codigo}");
                Console.WriteLine($"Data de cadastro: {item.DataCadastro}");
            }
        }

        // public void Deletar(int codigo)
        // {
        //     int index = ListaMarca.IndexOf(codigo);
        //     ListaMarca.RemoveAt(index);

        // }
    }
}