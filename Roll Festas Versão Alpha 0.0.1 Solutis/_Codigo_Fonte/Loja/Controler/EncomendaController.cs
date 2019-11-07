using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.Model;

namespace Loja.Controler
{
    class EncomendaController
    {
        public List<EncomendaModel> ListraEncomendasPordata()
        {
            List<EncomendaModel> ListadeEncomenda = new List<EncomendaModel>();

            DAOEncomenda dao = new DAOEncomenda();
            ListadeEncomenda = dao.ListarTodasAsEncomendasPorData();

            return ListadeEncomenda;
        }//LISTA ENCOMENDA POR ORDEM DE DATA

        public void NovaEncomenda(String tipo, String data_entrada, String data_entrega, String tema, String quantidade, String valor, String obs)
        {
            bool acesso = true;
            if (String.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("O tipo de encomenda é um campo obrigatório");
                acesso = false;
            }
            else if (String.IsNullOrEmpty(data_entrada) || String.IsNullOrEmpty(data_entrega))
            {
                MessageBox.Show("A data é um campo obrigatório");
                acesso = false;
            }
            else if (String.IsNullOrEmpty(quantidade))
            {
                MessageBox.Show("a quantidade é um campo obrigatório");
                acesso = false;
            }
            else if(String.IsNullOrEmpty(valor))
            {
                MessageBox.Show("O valor é um campo obrigatório");
                acesso = false;
            }
            else
            {
                acesso = true;
            }

            if (acesso == true)
            {
                DAOEncomenda dao = new DAOEncomenda();
                dao.NovaEncomenda(tipo, data_entrada, data_entrega, tema, quantidade, valor, obs);
            }
             

        }//SALVAR NOVA ENCOMENDA

        public EncomendaModel ExibirDetalhesdoDaEncomenda(String id)
        {

            EncomendaModel EncomendaModel = new EncomendaModel();
            DAOEncomenda dao = new DAOEncomenda();
            EncomendaModel = dao.ExibirDetalhesdoDaEncomenda(id);

            return EncomendaModel;
        }//EXIBIR DETALHES POR ID

        public bool EditarEncomenda(String tipo, String data_entrada, String data_entrega, String tema, String quantidade, String valor, String obs, String id)
        {
            bool acesso = false;
            if (String.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("O tipo de encomenda é um campo obrigatório");
                acesso = false;
            }
            else if (String.IsNullOrEmpty(data_entrada) || String.IsNullOrEmpty(data_entrega))
            {
                MessageBox.Show("A data é um campo obrigatório");
                acesso = false;
            }
            else if (String.IsNullOrEmpty(quantidade))
            {
                MessageBox.Show("a quantidade é um campo obrigatório");
                acesso = false;
            }
            else if (String.IsNullOrEmpty(valor))
            {
                MessageBox.Show("O valor é um campo obrigatório");
                acesso = false;
            }
            else
            {
                acesso = true;
            }

            if (acesso == true)
            {
                DAOEncomenda dao = new DAOEncomenda();
                dao.EditarEncomenda(tipo, data_entrada, data_entrega, tema, quantidade, valor, obs, id);
            }
            return acesso;

        }//EDITAR ENCOMENDA

        public void ApagarEncomenda(String id)
        {

            DAOEncomenda dao = new DAOEncomenda();
            dao.ApagarEncomenda(id);

        }//APAGAR ENCOMENDA
    }
}
