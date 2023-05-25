using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Fixação.Model;
using MVC_Fixação.View;

namespace MVC_Fixação.Controller
{
    public class EventoController
    {
        Evento evento = new Evento();

        EventoView eventoView = new EventoView();

        public void ListarEvento()
        {
            List<Evento> eventos = evento.Ler();
            
            eventoView.Listar(eventos);
        }


        public void CadastrarEvento()
        {
            Evento novoEvento = eventoView.Cadastrar();

            evento.Inserir(novoEvento);
        }
    }
}