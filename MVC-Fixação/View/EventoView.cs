using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Fixação.Model;

namespace MVC_Fixação.View
{
    public class EventoView
    {
        public void Listar(List<Evento> evento)
        {
            Console.Clear();

            foreach (var item in evento)
            {
                Console.WriteLine($"\nNome: {item.Nome}");
                Console.WriteLine($"Descrição: {item.Descricao}");
                Console.WriteLine($"Data: {item.Data}");
            }
        }

        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            Console.WriteLine($"Informe o nome do evento:");
            novoEvento.Nome = Console.ReadLine();
            
            Console.WriteLine($"Informe a descrição do evento:");
            novoEvento.Descricao = Console.ReadLine();

            Console.WriteLine($"Informe a data do evento:");
            novoEvento.Data = Console.ReadLine();

            return novoEvento;
        }
    }
}