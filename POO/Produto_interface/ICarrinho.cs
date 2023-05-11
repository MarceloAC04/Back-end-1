using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto_interface
{
    // interface para a classe Carrinho
    public interface ICarrinho
    {
        //definir(declarar) quais os metodos deverao ser implementados 
        //na classe que herdar desta interface

        // Create
        void Adicionar(Produto produto);

        // Read
        void Listar();

        // Update
        void Atualizar(int codigo, Produto produto);

        // Delete
        void Remover(Produto produto);
    }
}