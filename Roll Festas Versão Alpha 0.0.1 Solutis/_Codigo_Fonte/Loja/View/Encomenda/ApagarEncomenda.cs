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
    public partial class ApagarEncomenda : Form
    {
        public ApagarEncomenda()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

            EncomendaController encomenda = new EncomendaController();
            EncomendaModel encomendaeditavel = new EncomendaModel();

            encomendaeditavel = encomenda.ExibirDetalhesdoDaEncomenda(txtPesquisaCodigo.Text);

            TxtCodigo.Text = Convert.ToString(encomendaeditavel.Id);
            txtDescricao.Text = encomendaeditavel.Descricao;
            TxtTipo.Text = encomendaeditavel.TipoServico;
            TxtTema.Text = encomendaeditavel.Tema;
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            EncomendaController encomenda = new EncomendaController();
            encomenda.ApagarEncomenda(txtPesquisaCodigo.Text);

            txtPesquisaCodigo.Text = "";
            TxtCodigo.Text = "";
            TxtTipo.Text = "";
            TxtTema.Text = "";
            txtDescricao.Text = "";
            
        }
    }
}
