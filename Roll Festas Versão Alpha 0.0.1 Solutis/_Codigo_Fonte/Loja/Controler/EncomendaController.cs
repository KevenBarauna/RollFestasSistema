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
          
                DAOEncomenda dao = new DAOEncomenda();
                dao.NovaEncomenda(tipo, data_entrada, data_entrega, tema, quantidade, valor, obs);
            

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

        public bool ValidarEncomenda(string Tipo, string DataEntrada, string DataEntrega, string Tema, string Quantidade, string Valor, string Descricao)
        {
            //VERIFICA VALOR
            Controller ValidarValor = new Controller();
            if (!ValidarValor.VerificaDinheiro(Valor))
            {
                return false;
            }

            //VERIFICA VALOR
            if (Valor.Contains("."))
            {
                MessageBox.Show("O campo preço não pode conter PONTO, substitua por virgula");
                return false;
            }

            //VERIFICA VALOR
            if (String.IsNullOrEmpty(Valor))
            {
                MessageBox.Show("O valor é um campo obrigatório");
                return false;
            }

            //TIPO DE ENCOMENDA
            if (String.IsNullOrEmpty(Tipo))
            {
                MessageBox.Show("O tipo de encomenda é um campo obrigatório");
                return false;
            }

            //VERIFICA DATAS
            // if (String.IsNullOrEmpty(DataEntrada) || String.IsNullOrEmpty(DataEntrega))
            if (DataEntrada == "  /  /" || DataEntrega == "  /  /")
            {
                MessageBox.Show("A data é um campo obrigatório");
                return false;
            }

            //VERIFICA QUANTIDADE
            if (String.IsNullOrEmpty(Quantidade))
            {
                MessageBox.Show("A quantidade é um campo obrigatório");
                return false;
            }

            //VERIFICA QUANTIDADE
            if (!ValidarValor.VerificaDinheiro(Quantidade))
            {
                MessageBox.Show("Erro no campo quantidade");
                return false;
            }

            return true;

        }
    }
}
