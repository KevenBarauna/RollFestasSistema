using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RollFestas.Data;
using RollFestas.Models;
using RollFestas.View.Avisos;
using RollFestas.View.MensagemErro;

namespace RollFestas.Controllers
{
    class EncomendaController
    {
        EncomendaDAO DAO = new EncomendaDAO();

        //LISTA ENCOMENDA POR ORDEM DE DATA
        public List<EncomendaModel> ListraEncomendasPordata()
        {
            List<EncomendaModel> ListadeEncomenda = new List<EncomendaModel>();

            ListadeEncomenda = DAO.ListarTodasAsEncomendasPorData();

            return ListadeEncomenda;
        }

        //LISTA ENCOMENDA
        public List<EncomendaModel> ListraEncomendas()
        {
            List<EncomendaModel> ListadeEncomenda = new List<EncomendaModel>();

            ListadeEncomenda = DAO.ListarTodasAsEncomendas();

            return ListadeEncomenda;
        }

        //NOVA ENCOMENDA
        public bool NovaEncomenda(string Tipo, string DataEntrada, string DataEntrega, string Tema, int Entregue, string Quantidade, string Valor, string Descricao, string NomeCliente)
        {
            if (string.IsNullOrEmpty(Tipo))
            {
                var TelaErro = new Erro("Informe o tipo da encomenda");
                TelaErro.Show();
                return false;
            }
            if (string.IsNullOrEmpty(DataEntrada))
            {
                var TelaErro = new Erro("Informe a data que o pedido foi realizado");
                TelaErro.Show();
                return false;
            }
            if (string.IsNullOrEmpty(DataEntrega))
            {
                var TelaErro = new Erro("Informe a data da entrega da encomenda");
                TelaErro.Show();
                return false;
            }
            if (string.IsNullOrEmpty(Quantidade))
            {
                var TelaErro = new Erro("Informe a quantidade da encomenda");
                TelaErro.Show();
                return false;
            }
            if (string.IsNullOrEmpty(Valor))
            {
                var TelaErro = new Erro("Informe o valor total da encomenda");
                TelaErro.Show();
                return false;
            }
            if (string.IsNullOrEmpty(NomeCliente))
            {
                var TelaErro = new Erro("Informe o nome do cliente");
                TelaErro.Show();
                return false;
            }


            bool Sucesso = DAO.NovaEncomenda(Tipo, DataEntrada, DataEntrega, Tema, Entregue, Quantidade, Valor, Descricao, NomeCliente);

            if (Sucesso == true)
            {
                var Tela = new Sucesso("Encomenda cadastrada");
                Tela.Show();
            }
            return Sucesso;

        }

        //EXIBIR DETALHES POR ID
        public EncomendaModel ExibirDetalhesdoDaEncomenda(string Id)
        {

            EncomendaModel EncomendaModel = DAO.ExibirDetalhesdoDaEncomenda(Id);

            if (EncomendaModel.Id == 0)
            {
                var Tela = new Erro("Encomenda não encontrada");
            }

            return EncomendaModel;
        }

        //EDITAR ENCOMENDA
        public bool EditarEncomenda(string Tipo, string DataEntrada, string DataEntrega, string Tema, int Entregue, string Quantidade, string Valor, string Descricao, string NomeCliente, string Id)
        {

            if (string.IsNullOrEmpty(Tipo))
            {
                var TelaErro = new Erro("Informe o tipo da encomenda");
                TelaErro.Show();
                return false;
            }
            if (string.IsNullOrEmpty(DataEntrada))
            {
                var TelaErro = new Erro("Informe a data que o pedido foi realizado");
                TelaErro.Show();
                return false;
            }
            if (string.IsNullOrEmpty(DataEntrega))
            {
                var TelaErro = new Erro("Informe a data da entrega da encomenda");
                TelaErro.Show();
                return false;
            }
            if (string.IsNullOrEmpty(Quantidade))
            {
                var TelaErro = new Erro("Informe a quantidade da encomenda");
                TelaErro.Show();
                return false;
            }
            if (string.IsNullOrEmpty(Valor))
            {
                var TelaErro = new Erro("Informe o valor total da encomenda");
                TelaErro.Show();
                return false;
            }
            if (string.IsNullOrEmpty(NomeCliente))
            {
                var TelaErro = new Erro("Informe o nome do cliente");
                TelaErro.Show();
                return false;
            }

            bool Sucesso = DAO.EditarEncomenda(Tipo, DataEntrada, DataEntrega, Tema, Quantidade, Valor, Descricao, Entregue, Id);

            if (Sucesso == true)
            {
                var Tela = new Sucesso("Encomenda editada com sucesso");
                Tela.Show();
            }

            return Sucesso;



        }//EDITAR ENCOMENDA

        //APAGAR VENDA
        public bool ApagarEncomenda(string Id)
        {
            EncomendaModel Encomenda = new EncomendaModel();
            Encomenda = ExibirDetalhesdoDaEncomenda(Id);
            if (Encomenda.Id == 0)
            {
                var TelaErro = new ErroController("ECE", "Encomenda não encontrada", "", "", "");
                TelaErro.Show();
                return false;
            }

            bool Sucesso = DAO.ApagarEncomenda(Id);
            if (Sucesso == true)
            {
                var Tela = new Sucesso("Encomenda apagada");
                Tela.Show();
            }
            return Sucesso;


        }



    }

}
