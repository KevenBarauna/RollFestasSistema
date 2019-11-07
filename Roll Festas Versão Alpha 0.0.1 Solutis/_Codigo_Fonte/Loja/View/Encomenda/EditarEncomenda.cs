using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.Controler;
using Loja.Model;

namespace Loja.View.Encomenda
{
    public partial class EditarEncomenda : Form
    {
        public EditarEncomenda()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            EncomendaController encomenda = new EncomendaController();
            EncomendaModel encomendaeditavel = new EncomendaModel();

            encomendaeditavel = encomenda.ExibirDetalhesdoDaEncomenda(txtPesquisaCodigo.Text);

            TxtCodigo.Text = Convert.ToString(encomendaeditavel.Id);
            TxtDataEntrada.Text = encomendaeditavel.DataEntrada;
            TxtDataEntrega.Text = encomendaeditavel.DataEntrega;
            txtDescricao.Text = encomendaeditavel.Descricao;
            TxtValor.Text = encomendaeditavel.Valor;
            TxtQuantidade.Text = encomendaeditavel.Quantidade;
            TxtTipo.Text = encomendaeditavel.TipoServico;
            TxtTema.Text = encomendaeditavel.Tema;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            bool sucesso = false;
            EncomendaController encomenda = new EncomendaController();
            sucesso = encomenda.EditarEncomenda(TxtTipo.Text, TxtDataEntrada.Text, TxtDataEntrega.Text, TxtTema.Text, TxtQuantidade.Text, TxtValor.Text, txtDescricao.Text, TxtCodigo.Text);

            if (sucesso == true)
            {
                txtPesquisaCodigo.Text = "";
                TxtCodigo.Text = "";
                txtDescricao.Text = "";
                TxtQuantidade.Text = "";
                txtPesquisaCodigo.Focus();
                TxtTipo.Text = "";
                TxtTema.Text = "";
                TxtValor.Text = "";
                TxtDataEntrada.Text = "";
                TxtDataEntrega.Text = "";

            }
        }

        private void EditarEncomenda_Load(object sender, EventArgs e)
        {

        }
    }
}
