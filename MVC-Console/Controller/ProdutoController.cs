using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Console.Model;
using MVC_Console.View;

namespace MVC_Console.Controller
{
    public class ProdutoController
    {
        // instanciar objeto produto e produtoView
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

       //metodo controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            //lista de produtos chamada pela model
            List<Produto> produtos = produto.Ler();
            
            //chamada do metodo de exbição(VIEW) recebendo como argumento a lista
            produtoView.Listar(produtos);
        }

        // metodo controlador para acessar o cadastro de produto
        public void CadastrarProduto()
        {
            //chamada para a view que recebe cada objeto a ser inserido no csv
            Produto novoProduto = produtoView.Cadastrar();

            //chamada para a model para inserir esse objeto no csv
            produto.Inserir(novoProduto);
        }
    }
}