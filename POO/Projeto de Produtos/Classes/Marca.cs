using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_Produtos.Classes
{
    public class Marca
    {
        public int CodigoMarca { get; set; }
        public string NomeMarca { get; set; }
        private DateTime DataCadastro { get; set; }
        public List<Marca> ListaDeMarca = new List<Marca>();

        public void Cadastrar()
        {
            Marca novaMarca = new Marca();

            Console.WriteLine($"Digite o código do Marca");
            novaMarca.CodigoMarca = int.Parse(Console.ReadLine());
            while(novaMarca.CodigoMarca <=0)
            {
                Console.WriteLine($"Digite um código válido!");
                novaMarca.CodigoMarca = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Digite o nome do Marca");
            novaMarca.NomeMarca = Console.ReadLine();

            novaMarca.DataCadastro = DateTime.Now;

            ListaDeMarca.Add(novaMarca);

        }

        public void Listar()
        {

            if (ListaDeMarca.Count > 0)
            {
                foreach (Marca item in ListaDeMarca)
                {
                    Console.WriteLine($"Nome: {item.NomeMarca}, Código: {item.CodigoMarca}");
                    Console.WriteLine($"Data de cadastro: {item.DataCadastro}");
                }
                Console.WriteLine($"Aperte enter para sair");
                Console.ReadKey();


            }
            else
            {
                Console.WriteLine($"A lista de marcas está vazia!");
                Console.WriteLine($"Aperte enter para sair");
                Console.ReadKey();
            }
        }

        public void Deletar()
        {
            if (ListaDeMarca.Count > 0)
            {
                Marca marcaDeletar = new Marca();
                Console.WriteLine($"Insira o código da marca que queira remover");
                int codigo = int.Parse(Console.ReadLine());
                marcaDeletar = ListaDeMarca.Find(m => m.CodigoMarca == codigo)!;
                ListaDeMarca.Remove(marcaDeletar);
                Console.WriteLine($"Marca removida");
                Console.WriteLine($"Aperte enter para sair");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"A lista de marcas já está vazia!");
                Console.WriteLine($"Aperte enter para sair");
                Console.ReadKey();

            }

        }
    }
}