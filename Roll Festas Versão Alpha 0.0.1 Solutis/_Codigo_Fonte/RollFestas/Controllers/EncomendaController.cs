using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RollFestas.Data;
using RollFestas.Models;
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

        //NOVA ENCOMENDA
        public bool NovaEncomenda(string Tipo, string DataEntrada, string DataEntrega, string Tema, int Entregue, string Quantidade, string Valor, string Descricao,string NomeCliente)
        {
            if (string.IsNullOrEmpty(Tipo))
            {
                var TelaErro = new ErroController("ERN01E","Informe o tipo da encomenda","","","");
                TelaErro.Show();
                return false;
            }
            if (string.IsNullOrEmpty(DataEntrada))
            {
                var TelaErro = new ErroController("ER01E", "Informe a data que o pedido foi realizado", "", "", "");
                TelaErro.Show();
                return false;
            }
            if (string.IsNullOrEmpty(DataEntrega))
            {
                var TelaErro = new ErroController("ER01E", "Informe a data da entrega da encomenda", "", "", "");
                TelaErro.Show();
                return false;
            }
            if (string.IsNullOrEmpty(Quantidade))
            {
                var TelaErro = new ErroController("ER01E", "Informe a quantidade da encomenda", "", "", "");
                TelaErro.Show();
                return false;
            }
            if (string.IsNullOrEmpty(Valor))
            {
                var TelaErro = new ErroController("ER01E", "Informe o valor total da encomenda", "", "", "");
                TelaErro.Show();
                return false;
            }
            if (string.IsNullOrEmpty(NomeCliente))
            {
                var TelaErro = new ErroController("ER01E", "Informe o nome do cliente", "", "", "");
                TelaErro.Show();
                return false;
            }


            return DAO.NovaEncomenda(Tipo, DataEntrada, DataEntrega, Tema, Entregue ,Quantidade, Valor, Descricao, NomeCliente);


        }

        //EXIBIR DETALHES POR ID
        public EncomendaModel ExibirDetalhesdoDaEncomenda(string Id)
        {

            EncomendaModel EncomendaModel = DAO.ExibirDetalhesdoDaEncomenda(Id);

            return EncomendaModel;
        }

        //EDITAR ENCOMENDA
        public bool EditarEncomenda(string Tipo, string DataEntrada, string DataEntrega, string Tema, int Entregue, string Quantidade, string Valor, string Descricao, string NomeCliente, string Id)
        {

            if (string.IsNullOrEmpty(Tipo))
            {
                var TelaErro = new ErroController("CDB01","","","","");
                TelaErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(DataEntrada) || string.IsNullOrEmpty(DataEntrega))
            {
                var TelaErro = new ErroController("CDB01", "", "", "", "");
                TelaErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(Quantidade))
            {
                var TelaErro = new ErroController("CDB01", "", "", "", "");
                TelaErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(Valor))
            {
                var TelaErro = new ErroController("CDB01", "", "", "", "");
                TelaErro.Show();
                return false;
            }

            return DAO.EditarEncomenda(Tipo, DataEntrada, DataEntrega, Tema, Quantidade, Valor, Descricao, Id);
            
             

        }//EDITAR ENCOMENDA

        //APAGAR VENDA
        public bool ApagarEncomenda(string Id)
        {
            EncomendaModel Encomenda = new EncomendaModel();
            Encomenda = ExibirDetalhesdoDaEncomenda(Id);
            if (Encomenda.Id == 0)
            {
                var TelaErro = new ErroController("ECE", "Encomenda não encontrada", "","","");
                TelaErro.Show();
                return false;
            }
            else
            {
                return DAO.ApagarEncomenda(Id);
            }
            

        }



    }

}
