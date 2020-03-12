using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RollFestas.Data;
using RollFestas.Models;
using RollFestas.Utils;
using RollFestas.View.MensagemErro;

namespace RollFestas.Controllers
{
    class EventoController
    {

        EventoDAO DAO = new EventoDAO();

        //LISTA
        public List<EventoModel> ListraEventosPordata()
        {
            List<EventoModel> ListadeEvento = DAO.ListarTodasOsEventosPorData();

            return ListadeEvento;
        }

        //LISTA
        public List<EventoModel> ListratotosEventos()
        {
            List<EventoModel> ListadeEvento = DAO.ListarTodosOsEventos();

            return ListadeEvento;
        }

        //NOVA
        public bool NovoEvento(string Cep, string Local, string Descricao, string NomeCliente, string Telefone1, string Telefone2, string Email, string Tipo, string Data, string Hora, string ValorTotal, string ValorPago, int Entregue, string TipoPagamento, string ParteCartao, int StatusPagamento, string ValorPendente)
        {

            if (string.IsNullOrEmpty(Local))
            {
                var TelaErro = new Erro("Informe o local do evento");
                TelaErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(NomeCliente))
            {
                var TelaErro = new Erro("Informe o nome do cliente");
                TelaErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(Telefone1))
            {
                var TelaErro = new Erro("Informe o telefone(1) do cliente");
                TelaErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(Tipo))
            {
                var TelaErro = new Erro("Informe o tipo de evento");
                TelaErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(Data) || Data == "  /  /")
            {
                var TelaErro = new Erro("Informe a data do evento");
                TelaErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(Hora) || Hora == "  :")
            {
                var TelaErro = new Erro("Informe a hora do evento");
                TelaErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(ValorTotal))
            {
                var TelaErro = new Erro("Informe o valor total do evento");
                TelaErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(ValorPago))
            {
                var TelaErro = new Erro("Informe o valor valor pago");
                TelaErro.Show();
                return false;
            }

            //CADASTRAR EVENTO
            bool Sucesso = DAO.NovoEvento(Cep, Local, Descricao, NomeCliente, Telefone1, Telefone2, Email, Tipo, Data, Hora, ValorTotal, ValorPago, Entregue);

            if (Sucesso == true)
            {
                var Tela = new Sucesso("Evento cadastrado");
                Tela.Show();


                //SALVA VENDA
                var vendaC = new VendaController();
                bool SucessoVenda = vendaC.FinalizarVenda(GetDate.PegarDiaMesAnoAtual(), Program._Usuario.Nome, ValorTotal, ValorPago, TipoPagamento, ParteCartao, StatusPagamento, ValorPendente, NomeCliente, null, true) ;
                if (SucessoVenda == false)
                {
                    var TelaErro = new Erro("Não foi possível finalizar a venda, verifique os valores e tente novamente");
                    TelaErro.Show();
                    return false;
                }

            }
            return Sucesso;

        }

        //EXIBIR DETALHES POR ID
        public EventoModel ExibirDetalhesdoDoEvento(string Id)
        {

            EventoModel eventoM = DAO.ExibirDetalhesdoDoEvento(Id);

            if (eventoM.Id == 0)
            {
                var Tela = new Erro("Evento não encontrada");
            }

            return eventoM;
        }

        //EDITAR
        public bool EditarEvento(string Cep, string Local, string Descricao, string NomeCliente, string Telefone1, string Telefone2, string Email, string Tipo, string Data, string Hora, string ValorTotal, string ValorPago, int Entregue, string Id)
        {

            if (string.IsNullOrEmpty(Local))
            {
                var TelaErro = new Erro("Informe o local do evento");
                TelaErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(NomeCliente))
            {
                var TelaErro = new Erro("Informe o nome do cliente");
                TelaErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(Telefone1))
            {
                var TelaErro = new Erro("Informe o telefone(1) do cliente");
                TelaErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(Tipo))
            {
                var TelaErro = new Erro("Informe o tipo de evento");
                TelaErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(Data))
            {
                var TelaErro = new Erro("Informe a data do evento");
                TelaErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(Hora))
            {
                var TelaErro = new Erro("Informe a hora do evento");
                TelaErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(ValorTotal))
            {
                var TelaErro = new Erro("Informe o valor total do evento");
                TelaErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(ValorPago))
            {
                var TelaErro = new Erro("Informe o valor valor pago");
                TelaErro.Show();
                return false;
            }


            bool Sucesso = DAO.EditarEvento(Cep, Local, Descricao, NomeCliente, Telefone1, Telefone2, Email, Tipo, Data, Hora, ValorTotal, ValorPago, Entregue, Id);

            if (Sucesso == true)
            {
                var Tela = new Sucesso("Evento editado com sucesso");
                Tela.Show();
            }

            return Sucesso;



        }

    }
}
