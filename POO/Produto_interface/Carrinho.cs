using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto_interface
{
    public class Carrinho : ICarrinho
    {
        public float Valor { get; set; }

        List<Produto> carrinho = new List<Produto>();

        //implementar a logica para cada metodo
        public void Adicionar(Produto produto)
        {
            carrinho.Add(produto);
        }
        public void Listar()
        {
            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine($"Código: {p.Codigo} - Nome: {p.Nome} - Preço: {p.Preco:C}");
                }
            }
        }

        public void Atualizar(int codigo, Produto novoProduto)
        {
           carrinho.Find(x => x.Codigo == codigo).Nome =novoProduto.Nome;
           carrinho.Find(x => x.Codigo == codigo).Preco=novoProduto.Preco;
        }

        public void Remover(Produto produto)
        {
            carrinho.Remove(produto);
        }
    }
}