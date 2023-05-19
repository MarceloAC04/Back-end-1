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
        public  static List<Marca> ListaDeMarca = new List<Marca>();

        public void CadastrarMarca()
        {

            Console.WriteLine($"Digite o código do Marca");
            int codigo = int.Parse(Console.ReadLine());

            while (codigo <= 0)
            {
                Console.WriteLine($"Digite um código válido!");
                codigo = int.Parse(Console.ReadLine());
            }

            Marca verificaMarca = new Marca();

            verificaMarca = ListaDeMarca.Find(x => x.CodigoMarca == codigo)!;

            if (verificaMarca == null)
            {
                Marca novaMarca = new Marca();

                novaMarca.CodigoMarca = codigo;

                Console.WriteLine($"Digite o nome do Marca");
                novaMarca.NomeMarca = Console.ReadLine();

                novaMarca.DataCadastro = DateTime.Now;

                ListaDeMarca.Add(novaMarca);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Marca já  cadastrada!");
                Console.ResetColor();
                Console.WriteLine($"Aperte enter para continuar");
                Console.ReadKey();
            }


        }

        public void ListarMarca()
        {

            if (ListaDeMarca.Count > 0)
            {
                foreach (Marca item in ListaDeMarca)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Nome: {item.NomeMarca}, Código: {item.CodigoMarca}");
                    Console.WriteLine($"Data de cadastro: {item.DataCadastro}");
                    Console.WriteLine($"=====================================");
                    Console.ResetColor();
                }
                Console.WriteLine($"Aperte enter para sair");
                Console.ReadKey();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"A lista de marcas está vazia!");
                Console.ResetColor();
                Console.WriteLine($"Aperte enter para sair");
                Console.ReadKey();
            }
        }

        public void DeletarMarca()
        {
            if (ListaDeMarca.Count > 0)
            {
                Marca marcaDeletar = new Marca();
                Console.WriteLine($"Insira o código da marca que queira remover");
                int codigo = int.Parse(Console.ReadLine());
                marcaDeletar = ListaDeMarca.Find(m => m.CodigoMarca == codigo)!;
                ListaDeMarca.Remove(marcaDeletar);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Marca removida");
                Console.ResetColor();
                Console.WriteLine($"Aperte enter para sair");
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"A lista de marcas já está vazia!");
                Console.ResetColor();
                Console.WriteLine($"Aperte enter para sair");
                Console.ReadKey();

            }

        }
    }
}