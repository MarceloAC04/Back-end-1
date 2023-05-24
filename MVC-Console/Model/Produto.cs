using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Console.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

       // Caminho da pasta e do arquivo definido
        private const string PATH = "Database/Produto.csv";

        //criar um construtor

        public Produto()
        {
            //obter o caminho da pasta
            string pasta = PATH.Split("/")[0]; //Database

            //se não existir uma pasta Database, então cria-se uma
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //se não existir um arquivo csv no caminho, então cria-se um
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Produto> Ler()
        {
            //Instanciar uma lista de produto
            List<Produto> produtos = new List<Produto>();

            // array de string que recebe cada linha do csv
            string[] linhas = File.ReadAllLines(PATH);
            foreach (string item in linhas)
            {
                string[] atributos = item.Split(";");

                Produto p = new Produto();

                // atributos[0] = "001"
                // atributos[1] = "Coca"
                // atributos[2] = "6,50"

                p.Codigo = int.Parse(atributos[0]);
                p.Nome = atributos[1];
                p.Preco = float.Parse(atributos[2]);

                produtos.Add(p);
            }

            return produtos;

        }
    }
}